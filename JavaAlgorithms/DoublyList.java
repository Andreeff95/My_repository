public class DoublyList {
    Node head;
    Node tail;

    public void add(int value){
        Node node = new Node();
        node.val = value;
        if(head==null){
            head = node;
            tail = node;
        } else {
            tail.next = node;
            node.prev = tail;
            tail = node;
        }
    }

    public void add(int value, Node node){
        Node next = node.next;
        Node newNode = new Node();
        newNode.val = value;
        node.next = newNode;
        newNode.prev = node;
        if (next == null){
            tail = newNode;
        } else {
            next.prev = newNode;
            newNode.next = next;
        }
    }

    public void delete(Node node){
        Node prev = node.prev;
        Node next = node.next;
        if (prev == null){
            next.prev = null;
            head = next;
        } else {
            if(next == null){
                prev.next = null;
                tail = prev;
            } else {
                prev.next = next;
                next.prev = prev;
            }
        }  
    }

    public void revert(){
        Node currentNode = head;
        while ( currentNode != null){
            Node next = currentNode.next;
            Node prev = currentNode.prev;
            currentNode.next = prev;
            currentNode.prev = next;
            if (prev == null){
                tail = currentNode;
            }
            if (next == null){
                head = currentNode;
            }
            currentNode = next;
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
        head.prev = node;
        head = node;
    }

    public Integer peek(){
        Integer result = null;
        if(tail!=null){
            result = tail.val;
            tail.prev.next = null;
            tail = tail.prev; 
        }
        return result;
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
        Node prev;
    }
}
