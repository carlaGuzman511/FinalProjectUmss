using FluentValidation.Results;

public class ValidationException : Exception
{
    public List<ValidationFailure> Errors { get; }

    public ValidationException(List<ValidationFailure> failures)
    {
        Errors = failures;
    }
    public override string ToString()
    {
        return string.Join(Environment.NewLine, Errors);
    }
}
