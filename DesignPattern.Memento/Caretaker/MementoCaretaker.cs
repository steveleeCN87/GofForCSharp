using DesignPattern.Memento.Memento;

namespace DesignPattern.Memento.Caretaker
{
    /// <summary>
    /// 负责人：MementoCaretaker
    /// </summary>
    public class MementoCaretaker
    {
        public ChessmanMemento Memento { get; set; }
    }
}
