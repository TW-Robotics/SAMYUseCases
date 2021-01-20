import numpy
import math
from CRCLLib import crcl

# epsilon for testing whether a number is close to zero
_EPS = numpy.finfo(float).eps * 4.0
# axis sequences for Euler angles
_NEXT_AXIS = [1, 2, 0, 1]
# map axes strings to/from tuples of inner axis, parity, repetition, frame
_AXES2TUPLE = {
    'sxyz': (0, 0, 0, 0), 'sxyx': (0, 0, 1, 0), 'sxzy': (0, 1, 0, 0),
    'sxzx': (0, 1, 1, 0), 'syzx': (1, 0, 0, 0), 'syzy': (1, 0, 1, 0),
    'syxz': (1, 1, 0, 0), 'syxy': (1, 1, 1, 0), 'szxy': (2, 0, 0, 0),
    'szxz': (2, 0, 1, 0), 'szyx': (2, 1, 0, 0), 'szyz': (2, 1, 1, 0),
    'rzyx': (0, 0, 0, 1), 'rxyx': (0, 0, 1, 1), 'ryzx': (0, 1, 0, 1),
    'rxzx': (0, 1, 1, 1), 'rxzy': (1, 0, 0, 1), 'ryzy': (1, 0, 1, 1),
    'rzxy': (1, 1, 0, 1), 'ryxy': (1, 1, 1, 1), 'ryxz': (2, 0, 0, 1),
    'rzxz': (2, 0, 1, 1), 'rxyz': (2, 1, 0, 1), 'rzyz': (2, 1, 1, 1)}


def euler_to_matrix(ai, aj, ak, axes='sxyz'):
    ## Return homogeneous rotation matrix from Euler angles and axis sequence.
    #
    # ai, aj, ak : Euler's roll, pitch and yaw angles
    # axes : One of 24 axis sequences as string or encoded tuple
    #
    # >>> R = euler_matrix(1, 2, 3, 'syxz')
    # >>> numpy.allclose(numpy.sum(R[0]), -1.34786452)
    # True
    # >>> R = euler_matrix(1, 2, 3, (0, 1, 0, 1))
    # >>> numpy.allclose(numpy.sum(R[0]), -0.383436184)
    # True
    # >>> ai, aj, ak = (4*math.pi) * (numpy.random.random(3) - 0.5)
    # >>> for axes in _AXES2TUPLE.keys():
    # ...    R = euler_matrix(ai, aj, ak, axes)
    # >>> for axes in _TUPLE2AXES.keys():
    # ...    R = euler_matrix(ai, aj, ak, axes)

    try:
        firstaxis, parity, repetition, frame = _AXES2TUPLE[axes]
    except (AttributeError, KeyError):
        _TUPLE2AXES[axes]  # noqa: validation
        firstaxis, parity, repetition, frame = axes

    i = firstaxis
    j = _NEXT_AXIS[i + parity]
    k = _NEXT_AXIS[i - parity + 1]

    if frame:
        ai, ak = ak, ai
    if parity:
        ai, aj, ak = -ai, -aj, -ak

    si, sj, sk = math.sin(ai), math.sin(aj), math.sin(ak)
    ci, cj, ck = math.cos(ai), math.cos(aj), math.cos(ak)
    cc, cs = ci * ck, ci * sk
    sc, ss = si * ck, si * sk

    M = numpy.identity(4)
    if repetition:
        M[i, i] = cj
        M[i, j] = sj * si
        M[i, k] = sj * ci
        M[j, i] = sj * sk
        M[j, j] = -cj * ss + cc
        M[j, k] = -cj * cs - sc
        M[k, i] = -sj * ck
        M[k, j] = cj * sc + cs
        M[k, k] = cj * cc - ss
    else:
        M[i, i] = cj * ck
        M[i, j] = sj * sc - cs
        M[i, k] = sj * cc + ss
        M[j, i] = cj * sk
        M[j, j] = sj * ss + cc
        M[j, k] = sj * cs - sc
        M[k, i] = -sj
        M[k, j] = cj * si
        M[k, k] = cj * ci
    return M


def matrix_to_euler(matrix, axes='sxyz'):
    ## Return Euler angles from rotation matrix for specified axis sequence.
    #
    # axes : One of 24 axis sequences as string or encoded tuple
    #
    # Note that many Euler angle triplets can describe one matrix.
    #
    # >>> R0 = euler_matrix(1, 2, 3, 'syxz')
    # >>> al, be, ga = euler_from_matrix(R0, 'syxz')
    # >>> R1 = euler_matrix(al, be, ga, 'syxz')
    # >>> numpy.allclose(R0, R1)
    # True
    # >>> angles = (4*math.pi) * (numpy.random.random(3) - 0.5)
    # >>> for axes in _AXES2TUPLE.keys():
    # ...    R0 = euler_matrix(axes=axes, *angles)
    # ...    R1 = euler_matrix(axes=axes, *euler_from_matrix(R0, axes))
    # ...    if not numpy.allclose(R0, R1): print(axes, "failed")

    try:
        firstaxis, parity, repetition, frame = _AXES2TUPLE[axes.lower()]
    except (AttributeError, KeyError):
        _TUPLE2AXES[axes]  # noqa: validation
        firstaxis, parity, repetition, frame = axes

    i = firstaxis
    j = _NEXT_AXIS[i + parity]
    k = _NEXT_AXIS[i - parity + 1]

    M = numpy.array(matrix, dtype=numpy.float64, copy=False)[:3, :3]
    if repetition:
        sy = math.sqrt(M[i, j] * M[i, j] + M[i, k] * M[i, k])
        if sy > _EPS:
            ax = math.atan2(M[i, j], M[i, k])
            ay = math.atan2(sy, M[i, i])
            az = math.atan2(M[j, i], -M[k, i])
        else:
            ax = math.atan2(-M[j, k], M[j, j])
            ay = math.atan2(sy, M[i, i])
            az = 0.0
    else:
        cy = math.sqrt(M[i, i] * M[i, i] + M[j, i] * M[j, i])
        if cy > _EPS:
            ax = math.atan2(M[k, j], M[k, k])
            ay = math.atan2(-M[k, i], cy)
            az = math.atan2(M[j, i], M[i, i])
        else:
            ax = math.atan2(-M[j, k], M[j, j])
            ay = math.atan2(-M[k, i], cy)
            az = 0.0

    if parity:
        ax, ay, az = -ax, -ay, -az
    if frame:
        ax, az = az, ax
    return ax, ay, az

FLOAT_EPS = numpy.finfo(numpy.float).eps

def quaternion_to_matrix(r, i, j, k):
    # return value: numpy array 3 x 3
    w = r
    x = i
    y = j
    z = k

    Nq = w * w + x * x + y * y + z * z
    if Nq < FLOAT_EPS:
        return numpy.eye(3)
    s = 2.0 / Nq
    X = x * s
    Y = y * s
    Z = z * s
    wX = w * X
    wY = w * Y
    wZ = w * Z
    xX = x * X
    xY = x * Y
    xZ = x * Z
    yY = y * Y
    yZ = y * Z
    zZ = z * Z
    return numpy.array(
        [[1.0 - (yY + zZ), xY - wZ, xZ + wY],
         [xY + wZ, 1.0 - (xX + zZ), yZ - wX],
         [xZ - wY, yZ + wX, 1.0 - (xX + yY)]])

def matrix_to_quaternion(xAxis, zAxis):
    # return value: numpy vector
    # Qyx refers to the contribution of the y input vector component to
    # the x output vector component.  Qyx is therefore the same as
    # M[0,1].  The notation is from the Wikipedia article.

    xaxis = numpy.array([xAxis.I, xAxis.J, xAxis.K])
    zaxis = numpy.array([zAxis.I, zAxis.J, zAxis.K])
    yaxis = numpy.cross(zaxis, xaxis)

    Qxx = xAxis.I
    Qyx = xAxis.J
    Qzx = xAxis.K
    Qxy = yaxis[0]
    Qyy = yaxis[1]
    Qzy = yaxis[2]
    Qxz = zAxis.I
    Qyz = zAxis.J
    Qzz = zAxis.K

    # Fill only lower half of symmetric matrix
    K = numpy.array([
        [Qxx - Qyy - Qzz, 0, 0, 0],
        [Qyx + Qxy, Qyy - Qxx - Qzz, 0, 0],
        [Qzx + Qxz, Qzy + Qyz, Qzz - Qxx - Qyy, 0],
        [Qyz - Qzy, Qzx - Qxz, Qxy - Qyx, Qxx + Qyy + Qzz]]
    ) / 3.0
    # Use Hermitian eigenvectors, values for speed
    vals, vecs = numpy.linalg.eigh(K)
    # Select largest eigenvector, reorder to w,x,y,z quaternion
    q = vecs[[3, 0, 1, 2], numpy.argmax(vals)]
    # Prefer quaternion with positive w
    # (q * -1 corresponds to same rotation as q)
    if q[0] < 0:
        q *= -1
    return q

    # =========================================================
    #                   Helper functions
    # =========================================================


def get_pose_euler(waypoint):
    """ Convets a CRCL waypoint into a pose.
        Return value: pose as array
    """
    pose = [0, 0, 0, 0, 0, 0]
    xaxis = numpy.array([waypoint.XAxis.I, waypoint.XAxis.J, waypoint.XAxis.K])
    zaxis = numpy.array([waypoint.ZAxis.I, waypoint.ZAxis.J, waypoint.ZAxis.K])
    yaxis = numpy.cross(zaxis, xaxis)

    matrix = numpy.matrix([xaxis, yaxis, zaxis])

    pose[3], pose[5], pose[4] = matrix_to_euler(matrix, "sxzy")

    pose[0] = waypoint.Point.X
    pose[1] = waypoint.Point.Y
    pose[2] = waypoint.Point.Z

    return pose


def get_pose_quaternion():
    pass


def parse_waypoint(self, position):
    point = crcl.PointType(float(position["Point"]["X"]), float(position["Point"]["Y"]),
                              float(position["Point"]["Z"]))
    xaxis = crcl.VectorType(float(position["XAxis"]["I"]), float(position["XAxis"]["J"]),
                               float(position["XAxis"]["K"]))
    yaxis = crcl.VectorType(float(position["ZAxis"]["I"]), float(position["ZAxis"]["J"]),
                               float(position["ZAxis"]["K"]))
    waypoint = crcl.PoseType(point, xaxis, yaxis)
    return waypoint
