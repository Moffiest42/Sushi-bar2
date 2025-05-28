using System.ComponentModel.DataAnnotations;

public class Level
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Некорректный ввод")]
    [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Некорректный ввод")]
    [Display(Name = "Номер в меню")]
    public string? Level_Number { get; set; }

    [Required(ErrorMessage = "Некорректный ввод")]
    [StringLength(100, ErrorMessage = "Некорректный ввод")]
    [Display(Name = "тип")]
    public string? Bonus { get; set; }

    [Required(ErrorMessage = "Некорректный ввод")]
    [StringLength(200, ErrorMessage = "Некорректный ввод")]
    [Display(Name = "Описание")]
    public string? Capability { get; set; }

    public ICollection<Character> Characters { get; set; } = new List<Character>();
}
