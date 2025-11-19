namespace ToDoList.Models;

public class TodoItem
{
    public int Id {get;set;} 
    public string? Titulo {get;set;}
    public string? Descricao {get;set;}
    public DateTime CriadoEm {get;set;} 
    public DateTime TerminarEm {get;set;}  
    public bool Concluido {get;set;}


}