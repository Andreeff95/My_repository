import java.util.List;
import java.util.ArrayList;

public class Tree {
    Node root;

    public boolean existDeep(int value){
        if (root!=null){
            Node node = findDeep(root, value);
            if (node!=null){
                return true;
            }
        }
        return false;
    }

    private Node findDeep(Node node, int value){
        if(node.val == value){
            return node;
        } else {
            for(Node child: node.children){
                Node res = findDeep(child, value);
                if(res!=null){
                    return res;
                }
            }
        }
        return null;
    }

    public boolean existWidth(int value){
        if (root!=null){
            Node node = findWidth(value);
            if (node!=null){
                return true;
            }
        }
        return false;
    }

    private Node findWidth(int value){
        List<Node> line = new ArrayList<>();
        line.add(root);
        while(line.size()>0){
            List<Node> nextLine = new ArrayList<>();
            for (Node node: line){
                if (node.val == value){
                    return node;
                }
                nextLine.addAll(node.children);
            }
            line = nextLine;
        }
        return null;
    }

    public class Node{
        int val;
        List<Node> children;
    }
}
