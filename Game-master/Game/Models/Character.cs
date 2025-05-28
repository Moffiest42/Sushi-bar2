using System.ComponentModel.DataAnnotations;

public class Character
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Некорректный ввод")]
    [StringLength(60, MinimumLength = 3, ErrorMessage = "Некорректный ввод")]
    [RegularExpression(@"^[А-Я]+[а-яА-Я\s]*$",
        ErrorMessage = "Некорректный ввод")]
    [Display(Name = "Название")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Некорректный ввод")]
    [StringLength(50, ErrorMessage = "Некорректный ввод")]
    [Display(Name = "Тип")]
    public string? Weapon { get; set; }

    [Required(ErrorMessage = "Некорректный ввод")]
    [Display(Name = "Количество")]
    public int? LevelId { get; set; }

    public Level? Level { get; set; }

    [Required(ErrorMessage = "Некорректный ввод")]
    [Display(Name = "цена за штуку")]
    public int? GamerId { get; set; }
    public Gamer? Gamer { get; set; }
}