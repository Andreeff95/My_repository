public class List {
    Node head;

    
    public void revert(){
        if (head != null && head.next != null){
            Node temp = head;
            revert(head.next, head);
            temp.next = null;
        }
    }
    private void revert(Node currentNode, Node prevNode){
        if (currentNode.next == null){
            head = currentNode;
        } else {
            revert(currentNode.next, currentNode);
        }
        currentNode.next = prevNode;
        prevNode.next = null;
    }

    public void add(int value){
        Node node = new Node();
        node.val = value;
        if(head==null){
            head = node;
        } else {
            node.next = head;
            head = node;
        }
    }
    
    public Node find(int value){
        Node currentNode = head;
        while(currentNode!=null){
            if(currentNode.val==value){
                return currentNode;
            }
            currentNode=currentNode.next;
        }
        return null;
    }

    public void push(int value){
        Node node = new Node();
        node.val = value;
        node.next = head;
        head = node;
    }

    public Integer pop(){
        Integer result = null;
        if(head!=null){
            result = head.val;
            head = head.next;
        }
        return result;
    }

    public class Node{
        int val;
        Node next;
    }
}
