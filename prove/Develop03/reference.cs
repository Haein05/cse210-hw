public class Reference
{

    private string kg_reference;
    private string kg_verse;

    List<string> s_list = new List<string>(){
        "3 Nephi 6:15-Now the cause of this iniquity of the people was this—aSatan had great bpower, unto the stirring up of the people to do all manner of iniquity, and to the puffing them up with pride, tempting them to seek for power, and authority, and criches, and the vain things of the world." ,
        "1 Nephi 7:11-Yea, and how is it that ye have forgotten what great things the Lord hath done for us, in adelivering us out of the hands of Laban, and also that we should obtain the record?",
        "Jacob 4:3-Now in this thing we do rejoice; and we labor diligently to engraven these words upon plates, hoping that our beloved brethren and our children will receive them with thankful hearts, and look upon them that they may learn with joy and not with sorrow, neither with contempt, concerning their first aparents."
    };


    public Reference()
    {
        Console.WriteLine("Plean enter from 0 - 2 in order to get your scripture: ");
        int userinput = int.Parse(Console.ReadLine());
        string[] parts = s_list[userinput].Split("-");
        kg_reference = parts[0];
        kg_verse = parts[1];

    }

    public string getReference()
    {

        return kg_reference;
    }

    public string getVerse()
    {
        return kg_verse;
    }
}