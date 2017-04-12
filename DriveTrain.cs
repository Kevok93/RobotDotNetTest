using System;
using WPILib.Extras.NavX;

namespace RobotDotNetTest {
    //Driving related code in this file
    public partial class RobotDotNetTest {

        void setMotors(double left, double right) {
            leftMotorA.Set(left);
            leftMotorB.Set(left);
            leftMotorC.Set(left);

            rightMotorA.Set(right);
            rightMotorB.Set(right);
            rightMotorC.Set(right);
        }

        bool turnLeft(int targetHeading) {
            targetHeading = normalizeAngle(targetHeading);
            int currentHeading = normalizeAngle((int)navx.GetYaw());
            if (currentHeading < targetHeading) {
                setMotors(0, 0);
                return true;
            } else {
                setMotors(-1, 1);
                return false;
            }
        }

        public int normalizeAngle(int angle) {
            while (angle >  180) angle -= 360;
            while (angle > -180) angle += 360;
            return angle;
        }

    }
}