using System.ComponentModel.DataAnnotations;

public class Gamer
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Некорректный ввод")]
    [RegularExpression(@"^[А-Яа-яЁё\s-]+$", ErrorMessage = "Некорректный ввод")]
    [Display(Name = "Фамилия")]
    public string? Surname { get; set; }

    [Required(ErrorMessage = "Некорректный ввод")]
    [RegularExpression(@"^[А-Я]+[а-яА-Я\s]*$", ErrorMessage = "Некорректный ввод")]
    [Display(Name = "Имя")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Некорректный ввод")]
    [DataType(DataType.Date)]
    [Display(Name = "Дата заказа")]
    public DateTime DataRegistr { get; set; }

    [Required(ErrorMessage = "Некорректный ввод")]
    [EmailAddress(ErrorMessage = "Некорректный ввод")]
    [Display(Name = "Почта")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Некорректный ввод")]
    [StringLength(100, MinimumLength = 11, ErrorMessage = "Некорректный ввод")]
    [DataType(DataType.Password)]
    [Display(Name = "Номер телефона")]
    public string? Paswd { get; set; }

    [Required(ErrorMessage = "Некорректный ввод")]
    [Display(Name = "Ранг остроты")]
    public string? Rank { get; set; }

    public ICollection<Character> Characters { get; set; } = new List<Character>();

}
