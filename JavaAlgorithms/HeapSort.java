public class HeapSort {
    public static void main(String[] args) {
        int[] array = {4, 2, 5, 8, 1, 9, 2, 3, 6, 8, 5};
        printArray(array);
        heapSort(array);
        printArray(array);
    }
    public static void heapSort(int[] array){
        int count = array.length;
        heapify(array, count);
        int end = count-1;
        while(end>0){
            int temp = array[end];
            array[end] = array[0];
            array[0] = temp;
            heapSiftDown(array, 0, end-1);
            end--;
        }
        
    }

    public static void heapify(int[] array, int count) {
        int start = (count-2)/2;
        while(start>=0){
            heapSiftDown(array, start, count-1);
            start--;
        }        
    }
    public static void heapSiftDown(int[] array, int start, int end){
        int root = start;
        while ((root*2+1)<=end){
            int child = root*2+1;
            if(child+1<=end && array[child]<array[child+1]) child++;
            if(array[root]<array[child]){
                int temp= array[root];
                array[root] = array[child];
                array[child]=temp;
                root=child;
            } else return;
        }
    }
    public static void printArray(int[] array) {
        for(int i=0; i<array.length; i++){
            System.out.print(array[i]+" ");
        }
        System.out.println();        
    }
}
