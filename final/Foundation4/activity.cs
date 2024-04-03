public class Activity
{

    private DateTime date;

    protected int kg_length; 
    protected float kg_distance;

    protected string kg_name;
    public Activity(DateTime date, int length, float distance)
    {
        this.date = date;
        kg_length = length;
        this.kg_distance = distance;
    }

      public virtual float getDistance()
      {
            return kg_distance * 50/1000;
      }

    public void setDate(DateTime date){
        this.date = date;
    }
    public virtual float GetSpeed()
      {
           return  getDistance()/kg_length;
      }

    public virtual float GetPace()
      {
           return  kg_length/getDistance();
      }

    public string GetSummary()
      {
        return ($"{date} {kg_name}:({kg_length}min),{getDistance()}km,Speed:{GetSpeed()},Pace:{GetPace()}");
      }
}