using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25DH110577_NguyenHaTinh_Buoiso4
{
    internal class IntArray
    {
        private int[] arr;

        public int[] Arr
        {
            get { return arr; }
            set { arr = value; }
        }

        public IntArray()
        {
        }

        public IntArray(int k)
        {
            arr = new int[k];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 200);
            }
        }

        public IntArray(int[] a)
        {
            arr = new int[a.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = a[i];
            }
        }

        public IntArray(IntArray obj)
        {
            arr = new int[obj.arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = obj.arr[i];
            }
        }

        public bool KiemTraKT(int n)
        {
            return n >= 1 && n <= 1000000;
        }

        public void Nhap()
        {
            int n;

            while (true)
            {
                Console.Write("Nhap kich thuoc mang, n = ");
                n = int.Parse(Console.ReadLine());

                if (KiemTraKT(n))
                    break;

                Console.WriteLine("Kich thuoc khong hop le!");
            }

            arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap Arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
        }

        public int TimTuanTu(int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    return i;
            }

            return -1;
        }

        public int TimNhiPhan(int x)
        {
            int l = 0;
            int r = arr.Length - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (arr[mid] == x)
                    return mid;

                if (arr[mid] > x)
                    r = mid - 1;
                else
                    l = mid + 1;
            }

            return -1;
        }

        public int TimViTriMax()
        {
            int max = arr[0];
            int viTriMax = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= max)
                {
                    max = arr[i];
                    viTriMax = i;
                }
            }

            return viTriMax;
        }

        public bool XoaPhanTu(int x)
        {
            int viTri = TimTuanTu(x);

            if (viTri == -1)
                return false;

            int[] b = new int[arr.Length - 1];
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != viTri)
                {
                    b[j] = arr[i];
                    j++;
                }
            }

            arr = b;

            return true;
        }

        public void ChenSauMax(int x)
        {
            int viTriMax = TimViTriMax();

            int[] b = new int[arr.Length + 1];
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                b[j] = arr[i];
                j++;

                if (i == viTriMax)
                {
                    b[j] = x;
                    j++;
                }
            }

            arr = b;
        }

        public void HoanVi(ref int a, ref int b)
        {
            int tam = a;
            a = b;
            b = tam;
        }

        public void InterchangeSort()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        HoanVi(ref arr[i], ref arr[j]);
                    }
                }
            }
        }

        public void BubbleSort()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        HoanVi(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        public void SelectionSort()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }

                if (min != i)
                {
                    HoanVi(ref arr[i], ref arr[min]);
                }
            }
        }

        public void InsertionSort()
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int x = arr[i];
                int pos = i - 1;

                while (pos >= 0 && arr[pos] > x)
                {
                    arr[pos + 1] = arr[pos];
                    pos--;
                }

                arr[pos + 1] = x;
            }
        }

        public void QuickSort()
        {
            QuickSort(0, arr.Length - 1);
        }

        private void QuickSort(int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;

                while (arr[j] > pivot)
                    j--;

                if (i <= j)
                {
                    HoanVi(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSort(left, j);

            if (i < right)
                QuickSort(i, right);
        }

        public void HeapSort()
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                HoanVi(ref arr[0], ref arr[i]);
                Heapify(i, 0);
            }
        }

        private void Heapify(int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                HoanVi(ref arr[i], ref arr[largest]);
                Heapify(n, largest);
            }
        }

        public void MergeSort()
        {
            MergeSort(0, arr.Length - 1);
        }

        private void MergeSort(int left, int right)
        {
            if (left >= right)
                return;

            int mid = (left + right) / 2;

            MergeSort(left, mid);
            MergeSort(mid + 1, right);

            Merge(left, mid, right);
        }

        private void Merge(int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];

            int i = left;
            int j = mid + 1;
            int k = 0;

            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }

                k++;
            }

            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }

            for (i = 0; i < temp.Length; i++)
            {
                arr[left + i] = temp[i];
            }
        }

        public void ShellSort()
        {
            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = temp;
                }
            }
        }

        public void ShakerSort()
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        HoanVi(ref arr[i], ref arr[i + 1]);
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        HoanVi(ref arr[i], ref arr[i - 1]);
                    }
                }

                left++;
            }
        }

        public long InterchangeSortMinhHoa()
        {
            long count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        HoanVi(ref arr[i], ref arr[j]);
                        count += 3;

                        Xuat();
                    }
                }
            }

            return count;
        }

        public long BubbleSortMinhHoa()
        {
            long count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        HoanVi(ref arr[j], ref arr[j + 1]);
                        count += 3;

                        Xuat();
                    }
                }
            }

            return count;
        }

        public long SelectionSortMinhHoa()
        {
            long count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }

                if (min != i)
                {
                    HoanVi(ref arr[i], ref arr[min]);
                    count += 3;

                    Xuat();
                }
            }

            return count;
        }

        public long InsertionSortMinhHoa()
        {
            long count = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                int x = arr[i];
                count++;

                int pos = i - 1;

                while (pos >= 0 && arr[pos] > x)
                {
                    arr[pos + 1] = arr[pos];
                    count++;

                    pos--;
                }

                arr[pos + 1] = x;
                count++;

                Xuat();
            }

            return count;
        }

        public long QuickSortMinhHoa()
        {
            long count = 0;

            QuickSortMinhHoa(0, arr.Length - 1, ref count);

            return count;
        }

        private void QuickSortMinhHoa(int left, int right, ref long count)
        {
            int i = left;
            int j = right;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;

                while (arr[j] > pivot)
                    j--;

                if (i <= j)
                {
                    HoanVi(ref arr[i], ref arr[j]);
                    count += 3;

                    Xuat();

                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSortMinhHoa(left, j, ref count);

            if (i < right)
                QuickSortMinhHoa(i, right, ref count);
        }

        public long HeapSortMinhHoa()
        {
            long count = 0;
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                HeapifyMinhHoa(n, i, ref count);
            }

            for (int i = n - 1; i > 0; i--)
            {
                HoanVi(ref arr[0], ref arr[i]);
                count += 3;

                Xuat();

                HeapifyMinhHoa(i, 0, ref count);
            }

            return count;
        }

        private void HeapifyMinhHoa(int n, int i, ref long count)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                HoanVi(ref arr[i], ref arr[largest]);
                count += 3;

                Xuat();

                HeapifyMinhHoa(n, largest, ref count);
            }
        }

        public long MergeSortMinhHoa()
        {
            long count = 0;

            MergeSortMinhHoa(0, arr.Length - 1, ref count);

            return count;
        }

        private void MergeSortMinhHoa(int left, int right, ref long count)
        {
            if (left >= right)
                return;

            int mid = (left + right) / 2;

            MergeSortMinhHoa(left, mid, ref count);
            MergeSortMinhHoa(mid + 1, right, ref count);

            MergeMinhHoa(left, mid, right, ref count);

            Xuat();
        }

        private void MergeMinhHoa(
            int left,
            int mid,
            int right,
            ref long count)
        {
            int[] temp = new int[right - left + 1];

            int i = left;
            int j = mid + 1;
            int k = 0;

            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }

                count++;
                k++;
            }

            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
                count++;
            }

            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
                count++;
            }

            for (i = 0; i < temp.Length; i++)
            {
                arr[left + i] = temp[i];
                count++;
            }
        }

        public long ShellSortMinhHoa()
        {
            long count = 0;

            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    count++;

                    int j = i;

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        count++;

                        j -= gap;
                    }

                    arr[j] = temp;
                    count++;

                    Xuat();
                }
            }

            return count;
        }

        public long ShakerSortMinhHoa()
        {
            long count = 0;

            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        HoanVi(ref arr[i], ref arr[i + 1]);
                        count += 3;

                        Xuat();
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        HoanVi(ref arr[i], ref arr[i - 1]);
                        count += 3;

                        Xuat();
                    }
                }

                left++;
            }

            return count;
        }

        public long DemInterchangeSort()
        {
            long count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        HoanVi(ref arr[i], ref arr[j]);
                        count += 3;
                    }
                }
            }

            return count;
        }

        public long DemBubbleSort()
        {
            long count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        HoanVi(ref arr[j], ref arr[j + 1]);
                        count += 3;
                    }
                }
            }

            return count;
        }

        public long DemSelectionSort()
        {
            long count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }

                if (min != i)
                {
                    HoanVi(ref arr[i], ref arr[min]);
                    count += 3;
                }
            }

            return count;
        }

        public long DemInsertionSort()
        {
            long count = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                int x = arr[i];
                count++;

                int pos = i - 1;

                while (pos >= 0 && arr[pos] > x)
                {
                    arr[pos + 1] = arr[pos];
                    count++;

                    pos--;
                }

                arr[pos + 1] = x;
                count++;
            }

            return count;
        }

        public long DemQuickSort()
        {
            long count = 0;

            DemQuickSort(0, arr.Length - 1, ref count);

            return count;
        }

        private void DemQuickSort(int left, int right, ref long count)
        {
            int i = left;
            int j = right;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;

                while (arr[j] > pivot)
                    j--;

                if (i <= j)
                {
                    HoanVi(ref arr[i], ref arr[j]);
                    count += 3;

                    i++;
                    j--;
                }
            }

            if (left < j)
                DemQuickSort(left, j, ref count);

            if (i < right)
                DemQuickSort(i, right, ref count);
        }

        public long DemHeapSort()
        {
            long count = 0;

            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                DemHeapify(n, i, ref count);
            }

            for (int i = n - 1; i > 0; i--)
            {
                HoanVi(ref arr[0], ref arr[i]);
                count += 3;

                DemHeapify(i, 0, ref count);
            }

            return count;
        }

        private void DemHeapify(int n, int i, ref long count)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                HoanVi(ref arr[i], ref arr[largest]);
                count += 3;

                DemHeapify(n, largest, ref count);
            }
        }

        public long DemMergeSort()
        {
            long count = 0;

            DemMergeSort(0, arr.Length - 1, ref count);

            return count;
        }

        private void DemMergeSort(int left, int right, ref long count)
        {
            if (left >= right)
                return;

            int mid = (left + right) / 2;

            DemMergeSort(left, mid, ref count);
            DemMergeSort(mid + 1, right, ref count);

            DemMerge(left, mid, right, ref count);
        }

        private void DemMerge(
            int left,
            int mid,
            int right,
            ref long count)
        {
            int[] temp = new int[right - left + 1];

            int i = left;
            int j = mid + 1;
            int k = 0;

            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }

                count++;
                k++;
            }

            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
                count++;
            }

            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
                count++;
            }

            for (i = 0; i < temp.Length; i++)
            {
                arr[left + i] = temp[i];
                count++;
            }
        }

        public long DemShellSort()
        {
            long count = 0;

            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    count++;

                    int j = i;

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        count++;

                        j -= gap;
                    }

                    arr[j] = temp;
                    count++;
                }
            }

            return count;
        }

        public long DemShakerSort()
        {
            long count = 0;

            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        HoanVi(ref arr[i], ref arr[i + 1]);
                        count += 3;
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        HoanVi(ref arr[i], ref arr[i - 1]);
                        count += 3;
                    }
                }

                left++;
            }

            return count;
        }
    }
}