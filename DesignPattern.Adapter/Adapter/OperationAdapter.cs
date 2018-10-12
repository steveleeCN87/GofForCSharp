using DesignPattern.Adapter.Adaptee;
using DesignPattern.Adapter.Target;

namespace DesignPattern.Adapter.Adapter
{
    /// <summary>
    /// 适配器：成绩操作适配器类
    /// </summary>
    public class OperationAdapter : IScoreOperation
    {
        private QuickSortHelper sortTarget;
        private BinarySearchHelper searchTarget;

        public OperationAdapter()
        {
            sortTarget = new QuickSortHelper();
            searchTarget = new BinarySearchHelper();
        }

        public int Search(int[] array, int key)
        {
            return searchTarget.BinarySearch(array, key);
        }

        public int[] Sort(int[] array)
        {
            return sortTarget.QuickSort(array);
        }
    }
}
