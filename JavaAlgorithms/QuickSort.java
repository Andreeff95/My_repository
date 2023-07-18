public class QuickSort {
    public static void main(String[] args) {
        int[] array = {4, 2, 5, 8, 1, 9, 2, 3, 6, 8, 5};
        printArray(array);
        quickSort(array, 0, array.length-1);
        printArray(array);
    }
    public static void quickSort(int[] array, int start, int end){
        int left = start;
        int right = end;
        int pivot = array[(start+end)/2];
        do{
            while(array[left]<pivot){
                left++;
            }
            while(array[right]>pivot){
                right--;
            }
            if(left<=right){
                if (left<right){
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                left++; right--;
            }
        } while (left<=right);

        if (left < end){
            quickSort(array, left, end);
        }
        if(start<right){
            quickSort(array, start, right);
        }
    }
    public static void printArray(int[] array) {
        for(int i=0; i<array.length; i++){
            System.out.print(array[i]+" ");
        }
        System.out.println();        
    }
}
