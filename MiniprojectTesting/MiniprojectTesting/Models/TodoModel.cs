using MiniprojectTesting.Components.Pages.TodoLIst;

namespace MiniprojectTesting.Models
{
    public class TodoModel
    {
        public string TodoId { get; set; }
        public string Day { get; set; }
        public DateTime TodayDate { get; set; }
        public string Note { get; set; }
        public int DetailCount { get; set; }
        public List<TodoDetailModel> TodoDetails { get; set; } = new List<TodoDetailModel>();

        public TodoModel Clone()
        {
            return new TodoModel
            {
                TodoId = this.TodoId,
                Note = this.Note,
                Day = this.Day
            };
        }
    }
}