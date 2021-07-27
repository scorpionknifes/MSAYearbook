using System.ComponentModel.DataAnnotations;

namespace MSAYearbook.GraphQL.Comments
{
    public record AddCommentInput(
        string Content,
        [property: Key]
        string ProjectId);
}