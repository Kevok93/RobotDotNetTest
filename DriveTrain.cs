using System;
using WPILib.Extras.NavX;

namespace RobotDotNetTest {
    //Driving related code in this file
    public partial class RobotDotNetTest {

        void setMotors(double left, double right) {
            leftA.Set(left);
            leftB.Set(left);
            leftC.Set(left);

            rightA.Set(right);
            rightB.Set(right);
            rightC.Set(right);
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