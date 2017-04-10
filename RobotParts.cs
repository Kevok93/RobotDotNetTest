using CTRE;
using WPILib;
using WPILib.Extras.NavX;
using WPILib.SmartDashboard;

namespace RobotDotNetTest {
    public partial class RobotDotNetTest {
        private CANTalon
            leftA,
            leftB,
            leftC,
            rightA,
            rightB,
            rightC;

        private Joystick
            leftStick,
            rightStick;

        private AHRS navx;

        void initParts() {
            leftA = new CANTalon(0);
            leftB = new CANTalon(1);
            leftC = new CANTalon(2);
            rightA = new CANTalon(11);
            rightB = new CANTalon(12);
            rightC = new CANTalon(13);

            navx = new AHRS(SPI.Port.MXP);

            leftStick = new Joystick(0);
            rightStick = new Joystick(1);
        }
    }
}