class Video {

    public string kg_title;
    public string kg_author;
    public int kg_length;

    public Video (string title, string author, int length){
        this.kg_title = title;
        this.kg_author = author;
        this.kg_length = length;
    }
    List<Comment> comments = new List<Comment>{
        new Comment(),
        new Comment(),
        new Comment()
    
    };

    



    public int GetNumberComment(){

        return comments.Count;
    }


    public void display(){
        Console.WriteLine($"Title: {kg_title}, Author name: {kg_author}, Duration: {kg_length}");
        Console.WriteLine($"Comments : {GetNumberComment()}");
        foreach(Comment comment in comments){
            comment.display();
        }
        
    }
}
