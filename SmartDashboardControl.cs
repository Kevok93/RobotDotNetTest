
using OpenCvSharp;
using WPILib.SmartDashboard;

namespace RobotDotNetTest {
    public partial class RobotDotNetTest {
        int dashboardLoop = 0;
        const int DASHBOARD_LOOP_LENGTH = 25;

        public void incrementDashboardLoop() { dashboardLoop = (dashboardLoop + 1) % DASHBOARD_LOOP_LENGTH; }


        public void dashboardInit() {
            incrementDashboardLoop();
            if (dashboardLoop != 0) return;
            SmartDashboard.PutNumber  ( "autoChoice"   , 0                               );
            SmartDashboard.PutNumber  ( "Moat"         , 0                               );
        }

        public void dashboardDisabled() {
            incrementDashboardLoop();
            if (dashboardLoop != 0) return;
            SmartDashboard.PutNumber  ( "speedA"       , 60.0/ shooterSpeedA.GetPeriod() );
            SmartDashboard.PutNumber  ( "speedB"       , 60.0/ shooterSpeedB.GetPeriod() );
            SmartDashboard.PutBoolean ( "ballSensor"   , !ballSensor.Get()               );
            SmartDashboard.PutBoolean ( "tapeSensor"   , tapeSensor.Get()                );
            SmartDashboard.PutNumber  ( "armPot"       , armPot.GetAverageVoltage()      );
            SmartDashboard.PutNumber  ( "shooterAngle" , shooterPot.GetVoltage()         );
            SmartDashboard.PutNumber  ( "distL"        , leftDriveEncoder.GetRaw()       );
            SmartDashboard.PutNumber  ( "distR"        , rightDriveEncoder.GetRaw()      );
            SmartDashboard.PutBoolean ( "armLimit"     , armLowerLimit.Get()             );
            SmartDashboard.PutBoolean ( "armUpLimit"   , armUpperLimit.Get()             );
            SmartDashboard.PutNumber  ( "yaw"          , navx.GetYaw()                   );
            SmartDashboard.PutNumber  ( "pitch"        , navx.GetPitch()                 );
            SmartDashboard.PutNumber  ( "roll"         , navx.GetRoll()                  );
            SmartDashboard.PutBoolean ( "navXenabled"  , navx.IsConnected()              );
            SmartDashboard.PutNumber  ( "sonar"        , sonar.GetAverageVoltage()       );
            SmartDashboard.PutBoolean ( "shooterOn"    , false                           );
            /*
                Variables I haven't set yet
            SmartDashboard.PutNumber("powerA", powerA);
            SmartDashboard.PutNumber("powerB", powerB);
            SmartDashboard.PutBoolean("foundTarget", foundTarget);
            SmartDashboard.PutNumber("desiredSpeedA", setSpeedA);
            SmartDashboard.PutNumber("desiredSpeedB", setSpeedB);
            SmartDashboard.PutNumber("minRoll", minRoll);
            SmartDashboard.PutNumber("maxRoll", maxRoll);
            SmartDashboard.PutNumber("lastAutoStep", autoStep);
            SmartDashboard.PutNumber("defenseDistance", defenseDist);
            SmartDashboard.PutNumber("seeTapeDist", seeTapeDist);
            SmartDashboard.PutNumber("wallDist", wallDist);
            SmartDashboard.PutBoolean("onSpeed", onSpeed);
            SmartDashboard.PutNumber("turnAngle", turnToAngle);
            SmartDashboard.PutNumber("autoChoice", autoRoutine);
            SmartDashboard.PutNumber("moat", moat);
            */
        }

        public void dashboardTeleop() {
            incrementDashboardLoop();
            if (dashboardLoop != 0) return;
            SmartDashboard.PutNumber  ( "speedA"       , 60.0/ shooterSpeedA.GetPeriod() );
            SmartDashboard.PutNumber  ( "speedB"       , 60.0/ shooterSpeedB.GetPeriod() );
            SmartDashboard.PutBoolean ( "ballSensor"   , !ballSensor.Get()               );
            SmartDashboard.PutBoolean ( "tapeSensor"   , tapeSensor.Get()                );
            SmartDashboard.PutNumber  ( "armPot"       , armPot.GetAverageVoltage()      );
            SmartDashboard.PutNumber  ( "shooterAngle" , shooterPot.GetVoltage()         );
            SmartDashboard.PutNumber  ( "distL"        , leftDriveEncoder.GetRaw()       );
            SmartDashboard.PutNumber  ( "distR"        , rightDriveEncoder.GetRaw()      );
            SmartDashboard.PutBoolean ( "armLimit"     , armLowerLimit.Get()             );
            SmartDashboard.PutBoolean ( "armUpLimit"   , armUpperLimit.Get()             );
            SmartDashboard.PutNumber  ( "yaw"          , navx.GetYaw()                   );
            SmartDashboard.PutNumber  ( "pitch"        , navx.GetPitch()                 );
            SmartDashboard.PutNumber  ( "roll"         , navx.GetRoll()                  );
            SmartDashboard.PutBoolean ( "navXenabled"  , navx.IsConnected()              );
            SmartDashboard.PutNumber  ( "sonar"        , sonar.GetAverageVoltage()       );
            /*
                Variables I haven't set yet
            SmartDashboard.PutNumber("powerA", powerA);
            SmartDashboard.PutNumber("powerB", powerB);
            SmartDashboard.PutBoolean("foundTarget", foundTarget);
            */
        }

        public void dashboardAuto() {
            incrementDashboardLoop();
            if (dashboardLoop != 0) return;

            //We didn't do any printing.
            //But we could have.
            //SmartDashboard.putBoolean("foundTarget", foundTarget);
        }
    }
}