using CTRE;
using WPILib;
using WPILib.Extras.NavX;
using WPILib.Interfaces;

namespace RobotDotNetTest {
    public partial class RobotDotNetTest {

        CANTalon
            //Drive
            leftMotorA,
            leftMotorB,
            leftMotorC,
            rightMotorA,
            rightMotorB,
            rightMotorC,
            //Shooter
            shooterA,
            shooterB,
            shooterAngle,
            //Scaling
            scalingA,
            scalingB,
            scalingArm,
            //Ball Control
            collector,
            indexer;

        Joystick
            leftStick,
            rightStick;

        //Digital I/O
        DigitalInput
            ballSensor,
            armUpperLimit,
            armLowerLimit,
            tapeSensor;
        Encoder
            leftDriveEncoder,
            rightDriveEncoder;
        Counter
            shooterSpeedA,
            shooterSpeedB;
        Servo flag;

        //Analog In
        AnalogInput
            armPot,
            shooterPot,
            sonar;

        AHRS navx;

        //Technically not a part, but whatever
        Timer autoTimer;

        PIDController
            angleControl,
            driveControl;


        void initParts() {
            scalingB          = new CANTalon(0);
            rightMotorA       = new CANTalon(1) {NeutralMode = NeutralMode.Brake, Inverted = true};
            rightMotorB       = new CANTalon(2) {NeutralMode = NeutralMode.Brake, Inverted = true};
            rightMotorC       = new CANTalon(3) {NeutralMode = NeutralMode.Brake, Inverted = true};
            scalingArm        = new CANTalon(4) {NeutralMode = NeutralMode.Brake};
            indexer           = new CANTalon(5) {NeutralMode = NeutralMode.Brake};
            collector         = new CANTalon(6);
            shooterA          = new CANTalon(9);
            shooterB          = new CANTalon(10);
            shooterAngle      = new CANTalon(11) {NeutralMode = NeutralMode.Brake};
            leftMotorA        = new CANTalon(12) {NeutralMode = NeutralMode.Brake};
            leftMotorB        = new CANTalon(13) {NeutralMode = NeutralMode.Brake};
            leftMotorC        = new CANTalon(14) {NeutralMode = NeutralMode.Brake};
            scalingA          = new CANTalon(15);

            leftDriveEncoder  = new Encoder(0, 1, false, EncodingType.K1X);
            rightDriveEncoder = new Encoder(2, 3,  true, EncodingType.K1X);
            shooterSpeedB     = new Counter(4) { SamplesToAverage = 5};
            shooterSpeedA     = new Counter(5) { SamplesToAverage = 5};
            armLowerLimit     = new DigitalInput(6);
            ballSensor        = new DigitalInput(7);
            tapeSensor        = new DigitalInput(8);
            armUpperLimit     = new DigitalInput(9);
            flag              = new Servo(9);

            armPot            = new AnalogInput(0);
            shooterPot        = new AnalogInput(1);
            sonar             = new AnalogInput(2);

            navx              = new AHRS(SPI.Port.MXP, (byte)50);
            autoTimer         = new Timer();

            leftStick         = new Joystick(0);
            rightStick        = new Joystick(1);

            angleControl = new PIDController(.03,  .0005, .5,  navx, null) {Continuous = true};
            angleControl.SetInputRange(-180,180);
            angleControl.SetOutputRange(-.6, .6);
            angleControl.SetAbsoluteTolerance(1.0);

            driveControl = new PIDController(.04, .00005, .03, navx, null) {Continuous = true};
            driveControl.SetInputRange(-180,180);
            driveControl.SetOutputRange(-1, 1);


        }
    }
}