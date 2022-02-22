public class TestObjectA
{
    public Guid Id { get; set; }
    public string? Name {get; set; }
    public int? Number {get; set; }
    public bool? IsValid { get; set; }
    public TestEnum? EnumVal {get; set; }
    public List<TestObjectB>? TestB { get; set; }
}