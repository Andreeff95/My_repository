public class RBTree {

    private Node root;
    public boolean add(int value){
        if (root != null){
            boolean res = addNode(root, value);
            root = rebalance(root);
            root.col = Color.BLACK;
            return res;
        } else {
            root = new Node();
            root.col = Color.BLACK;
            root.val = value;
            return true;
        }
    }
    private boolean addNode(Node nd, int value){
        if (nd.val == value){
            return false;
        } else {
            if (nd.val > value) {
                if (nd.leftChild != null){
                    boolean res = addNode(nd.leftChild, value);
                    nd.leftChild = rebalance(nd.leftChild);
                    return res;
                } else {
                    nd.leftChild = new Node();
                    nd.leftChild.col = Color.RED;
                    nd.leftChild.val = value;
                    return true;
                }
            } else {
                if (nd.rightChild != null){
                    boolean res = addNode(nd.rightChild, value);
                    nd.rightChild = rebalance(nd.rightChild);
                    return res;
                } else {
                    nd.rightChild = new Node();
                    nd.rightChild.col = Color.RED;
                    nd.rightChild.val = value;
                    return true;
                }
            }
        }
    } 
    private Node rebalance(Node nd){
        Node res = nd;
        boolean needBalance;
        do {
            needBalance = false;
            if ((res.rightChild != null && res.rightChild.col == Color.RED) &&
            (res.leftChild == null || res.leftChild.col == Color.BLACK)){
                needBalance = true;
                res = rightSwap(res);
            }
            if ((res.leftChild != null && res.leftChild.col == Color.RED) &&
                    (res.leftChild.leftChild != null && res.leftChild.leftChild.col == Color.RED)){
                needBalance = true;
                res = leftSwap(res);
            }
            if ((res.leftChild != null && res.leftChild.col == Color.RED) &&
                    (res.rightChild != null && res.rightChild.col == Color.RED)){
                needBalance = true;
                colorSwap(res);
            }
        } while (needBalance);
        return res;
    }
    private Node rightSwap(Node nd){
        Node right = nd.rightChild;
        Node temp = right.leftChild;
        right.leftChild = nd;
        nd.rightChild = temp;
        right.col = nd.col;
        nd.col = Color.RED;
        return right;
    }
    private Node leftSwap(Node nd){
        Node left = nd.leftChild;
        Node temp = left.rightChild;
        left.rightChild = nd;
        nd.leftChild = temp;
        left.col = Color.RED;
        return left;

    }
    private void colorSwap(Node nd){
        nd.rightChild.col = Color.BLACK;
        nd.leftChild.col = Color.BLACK;
        nd.col = Color.RED;
    }


    private class Node {
        private int val;
        private Color col;
        private Node leftChild;
        private Node rightChild;

        @Override
        public String toString(){
            return "Node{"+"value="+val+", color="+col+"}";
        }
    }

    private enum Color{
        RED, BLACK
    }
}