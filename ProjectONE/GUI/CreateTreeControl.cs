using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectONE.GUI
{
    class CreateTreeControl
    {
        Tree TempTree;
        String Path;

        public CreateTreeControl(int depth, int splitsize, LinkedList<Attribute> vertexesAttributes, LinkedList<Attribute> edgesAttributes, String path, String treetype)
        {
            this.Path = path;

            //da sostituire
            this.TempTree = Tree.getRandomTree(depth, splitsize, vertexesAttributes, edgesAttributes);
            this.TempTree.type = treetype;

           /* generateRandomVertexAttributes(vertexesAttributes);
            generateRandomVertexAttributes(edgesAttributes); TODO Agostino*/
            if(generateTreeFile() == false)
                MessageBox.Show("Problems while storing file into file");
            else
                MessageBox.Show("Your tree is in the file");
            if(uploadTree() == false)
                MessageBox.Show("Problems while uploading tree to database");
            else
                MessageBox.Show("Your tree is on the Database");
        }

        public bool uploadTree()
        {
            //new Engine();....
            return true; //TODO update
        }

        public bool generateTreeFile()
        {
            return TempTree.ToFile(this.Path);
        }
    }
}
