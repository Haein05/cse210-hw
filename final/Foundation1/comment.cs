class Comment{

    public string kg_name;
    public string kg_comment;

    List<string> names= new List<string>{
        "Sam",
        "Mile",
        "Justin",
        "Kim"
    };
    
    List<string> comments = new List<string>{
    "Incredible performance!",
    "Well done, keep it up!",
    "This is absolutely fantastic!",
    "I'm blown away by this!",
    "Truly inspiring work!"
    };

    public Comment(){
        
        Random random = new Random();
        int randomIndex = random.Next(names.Count);
        kg_name = names[randomIndex];
        kg_comment= comments[random.Next(comments.Count)];


    }
 
    public void display(){
        Console.WriteLine($"{kg_name}\n \"{kg_comment}\" \n \n");
    }

}


