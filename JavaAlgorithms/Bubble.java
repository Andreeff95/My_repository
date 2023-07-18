public class Bubble {
    public static void main(String[] args) {
        int[] array = {4, 2, 5, 8, 1, 9, 2, 3, 6, 8, 5};
        printArray(array);
        bubbleSort(array);
        printArray(array);
    }
    public static void bubbleSort(int[] array){
        boolean finish;
        do {
            finish = true;
            for (int i=0; i<array.length-1; i++){
                if (array[i]>array[i+1]){
                    int temp = array[i];
                    array[i] = array[i+1];
                    array[i+1] = temp;
                    finish = false;
                }
            }
        } while (!finish);
    }
    public static void printArray(int[] array) {
        for(int i=0; i<array.length; i++){
            System.out.print(array[i]+" ");
        }
        System.out.println();        
    }
}
