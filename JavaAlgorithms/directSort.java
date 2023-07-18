public class directSort {
    public static void main(String[] args) {
        int[] array = {4, 2, 5, 8, 1, 9, 2, 3, 6, 8, 5};
        printArray(array);
        dirSort(array);
        printArray(array);
    }
    public static void dirSort(int[] array){
        for (int i=0; i<array.length-1; i++){
            int minPos = i;
            for (int j = i+1; j < array.length; j++) {
                if (array[j] < array[minPos]){
                    minPos = j;
                }
            }
            if (i!=minPos){
                int temp = array[i];
                array[i] = array[minPos];
                array[minPos] = temp;
            }

        }
    } 
    
    public static void printArray(int[] array) {
        for(int i=0; i<array.length; i++){
            System.out.print(array[i]+" ");
        }
        System.out.println();        
    }
}
