using WPILib;
using WPILib.SmartDashboard;

namespace RobotDotNetTest {
    public partial class RobotDotNetTest : IterativeRobot {
        public override void RobotInit() {
            //Function defined in RobotParts.cs
            initParts();
            //Variable defined in Autonomous.cs
            autonomousMethod = (int)SmartDashboard.GetNumber("Autonomous Method",0);
        }

        //Auto Periodic is in Autonomous.cs
        //public override void AutonomousPeriodic() {}


        //Going to try not to do anything fancy for teleop, please try to use functions as much as possible so we don't conflict as much.
        //Easier to change how setMotors works than to change how TeleopPeriodic works.
        public override void TeleopPeriodic() {

            double
                joyX = leftStick.GetX(),
                joyY = leftStick.GetY();

            double
                leftPower  = joyY - joyX,
                rightPower = joyY + joyX;

            //DriveTrain.cs
            setMotors(leftPower,rightPower);
        }
    }
}