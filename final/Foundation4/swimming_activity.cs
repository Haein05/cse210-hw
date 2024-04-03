public class SwimmingActivity:Activity
{
      private float kg_laps;

      public SwimmingActivity(DateTime date, int length,float laps) : base(date, length,laps)
      {
            this.kg_laps = laps;
            kg_name = "Swimming";
      }

      public override float getDistance()
      {
            return kg_laps * 50/1000;
      }

      public override float GetPace()
      {
           return  kg_length/getDistance();
      }

}