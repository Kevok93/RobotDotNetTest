namespace RobotDotNetTest {
    public partial class RobotDotNetTest {
        private int autonomousStep   = 0;
        private int autonomousMethod = 0;

        public override void AutonomousPeriodic() {
            switch (autonomousMethod) {
                case 0:
                    doAutonomousProgram1();
                    break;
                //call your programs
            }
        }

    //You could even have these in different files if you wanted
        public void doAutonomousProgram1() {
            switch (autonomousStep) {
                case 0:
                    navx.Reset();
                    //turnLeft = DriveTrain.cs
                    bool doneTurning = turnLeft(90);
                    if (doneTurning) autonomousStep = 1;
                    break;
            }
        }
    }
}