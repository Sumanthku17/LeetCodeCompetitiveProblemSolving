public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var size = board.Length;
        HashSet<char>[] rows = new HashSet<char>[size];
        HashSet<char>[] cols = new HashSet<char>[size];
        HashSet<char>[] boxes = new HashSet<char>[size];

        // Populate the arrays with new HashSet instances
        for (int i = 0; i < size; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }


        for(int r =0; r<board.Length; r++)
        {
            for(int c =0; c<board[r].Length; c++)
            {
                if(board[r][c] == '.')
                {
                    continue;
                }

                var boxIndex = (r/3) * 3 + (c/3);

                if(!rows[r].Add(board[r][c]))
                {
                    return false;   
                }

                if(!cols[c].Add(board[r][c]))
                {
                    return false;   
                }

                if(!boxes[boxIndex].Add(board[r][c]))
                {
                    return false;   
                }
            }
        }
        return true;
    }
}