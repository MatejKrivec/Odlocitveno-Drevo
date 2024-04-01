using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms.Design;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ProjektnaNaloga_Krivec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            string rootNodeText = textBoxDodaj.Text;
            TreeNode rootNode = new TreeNode(rootNodeText);
            Drevo.Nodes.Add(rootNode);
        }

        private void DodajAlternativo_Click(object sender, EventArgs e)
        {
            // Get the currently selected node in the tree view
            TreeNode selectedNode = Drevo.SelectedNode;

            // Check if there are any nodes in the tree view
            if (Drevo.Nodes.Count == 0)
            {
                MessageBox.Show("There are no existing nodes. Please add a root node first.", "Error");
                return;
            }

            if (selectedNode == null)
            {
                MessageBox.Show("Please select a node to add a child node to.", "Error");
                return;
            }

            // Check if the selected node is the root node
            if (selectedNode != Drevo.Nodes[0])
            {
                MessageBox.Show("You can only add alternatives to the root node.", "Error");
                return;
            }

            if (textBoxAlternativa.Text == "")
            {
                MessageBox.Show("You must name the alternative.", "Error");
                return;
            }

            // Get the text of the child node from a textbox
            string childNodeText = textBoxAlternativa.Text;

            // Create a new instance of Vrednosti and set the vrednost property
            double vrednost = 0;
            if (!string.IsNullOrEmpty(textBoxVrednostAlternative.Text))
            {
                vrednost = double.Parse(textBoxVrednostAlternative.Text);
            }

            var vrednosti = new Vrednosti
            {
                vrednost = vrednost,
                verjetnost = 0 // Set to null since it's always null
            };

            // Serialize the vrednosti object to a string and append it to the branch text
            string branchText = string.IsNullOrEmpty(textBoxVrednostAlternative.Text)
                ? $"{childNodeText} /"
                : $"{childNodeText} /{textBoxVrednostAlternative.Text}$";

            // Create a new TreeNode with the specified text
            TreeNode childNode = new TreeNode(branchText);

            // Set the Tag property of the branch node to the vrednosti object
            childNode.Tag = vrednosti;

            // Add the child node to the selected node's collection of child nodes
            selectedNode.Nodes.Add(childNode);

            // Select the newly added child node
            Drevo.SelectedNode = childNode;

            // Clear the text in the child node textbox
            textBoxAlternativa.Clear();
            textBoxVrednostAlternative.Clear();
        }


        private void OdstraniButton_Click(object sender, EventArgs e)
        {
            // Get the currently selected node in the tree view
            TreeNode selectedNode = Drevo.SelectedNode;

            if (selectedNode == null)
            {
                MessageBox.Show("Please select a node to delete.", "Error");
                return;
            }

            // Remove the selected node from its parent's collection of child nodes
            selectedNode.Remove();
        }

        private void DodajVejo_Click(object sender, EventArgs e)
        {
            // Get the currently selected node in the tree view
            TreeNode selectedNode = Drevo.SelectedNode;

            // Check if a node is selected and if it's not the root node
            if (selectedNode == null)
            {
                MessageBox.Show("Please select a node to add a branch to.", "Error");
                return;
            }
            else if (selectedNode == Drevo.Nodes[0])
            {
                MessageBox.Show("You cannot add child nodes directly to the root node.", "Error");
                return;
            }

            // Get the text of the branch name, utility value, and additional value from textboxes
            string branchName = textBoxVeja.Text;
            string branchUtility = textBoxVerjetnostVeje.Text;
            string branchValue = textBoxVrednostVeje.Text;


            // Validate the input in textBoxVerjetnostVeje and textBoxValue
            if (!double.TryParse(branchUtility, out double probability) || probability < 0 || probability > 100)
            {
                MessageBox.Show("Please enter a valid probability value between 0 and 100.", "Error");
                return;
            }

            double value;
            if (string.IsNullOrWhiteSpace(branchValue) || !double.TryParse(branchValue, out value))
            {
                MessageBox.Show("Please enter a valid value.", "Error");
                return;
            }

            probability /= 100.0; // Divide by 100

            // Create an instance of Vrednosti to store utility and value values
            var vrednosti = new Vrednosti
            {
                verjetnost = probability,
                vrednost = value
            };

            // Create the node text in the desired format
            string branchText = $"{branchName}({branchUtility}%) /{branchValue}$";

            // Create a new TreeNode with the branch text
            TreeNode branchNode = new TreeNode(branchText);

            // Set the Tag property of the branch node to the vrednosti instance
            branchNode.Tag = vrednosti;

            // Add the branch node to the selected node's collection of child nodes
            selectedNode.Nodes.Add(branchNode);

            // Update the selected node's text to remove everything onward from the comma (",")
            int commaIndex = selectedNode.Text.IndexOf("/");
            if (commaIndex >= 0)
            {
                selectedNode.Text = selectedNode.Text.Substring(0, commaIndex + 1);
            }

            // Set the vrednost value of the selected node's Tag to 0           //////////////////////////////////////////
            if (selectedNode.Tag is Vrednosti selectedNodeVrednosti)
            {
                selectedNodeVrednosti.vrednost = 0;
            }

            // Clear the text in the branch name, utility value, and additional value textboxes
            textBoxVeja.Clear();
            textBoxVerjetnostVeje.Clear();
            textBoxVrednostVeje.Clear();
        }



        private void Izračunaj_Click(object sender, EventArgs e)
        {
            // Exclude the root node and calculate sum for each lower node
            foreach (TreeNode rootNode in Drevo.Nodes)
            {
                foreach (TreeNode lowerNode in rootNode.Nodes)
                {
                    CalculateSum(lowerNode);
                }
            }

            // Check if there is a root node
            if (Drevo.Nodes.Count == 0)
            {
                label10.Text = "No root node found.";
                return;
            }

            // Get the root node of the tree view
            TreeNode root = Drevo.Nodes[0];

            // Check if the root node has any child nodes
            if (root.Nodes.Count == 0)
            {
                label10.Text = "No child nodes found.";
                return;
            }

            // Create an array to store the child node texts
            string[] childNodeTexts = new string[root.Nodes.Count];

            // Iterate through the child nodes of the root node and store their texts in the array
            for (int i = 0; i < root.Nodes.Count; i++)
            {
                TreeNode childNode = root.Nodes[i];
                childNodeTexts[i] = childNode.Text;
            }

            double[] numbersOnlyArray = new double[childNodeTexts.Length];

            for (int i = 0; i < childNodeTexts.Length; i++)
            {
                string nodeText = childNodeTexts[i];

                // Remove all non-integer characters from the string
                string numbersOnly = new string(nodeText.Where(c => char.IsDigit(c) || c == ',').ToArray());

                // Convert the string to a double
                if (double.TryParse(numbersOnly, out double number))
                {
                    numbersOnlyArray[i] = number;
                }
            }
            
            double maxNumber = numbersOnlyArray.Max();

            // Find the string that contains the maximum number
            string maxNumberString = null;

            List<string> MatchingStrings = new List<string>();

            foreach (string nodeText in childNodeTexts)
            {
                if (nodeText.Contains(maxNumber.ToString()))
                {
                    // maxNumberString = nodeText;
                    MatchingStrings.Add(nodeText);
                    //break;
                }
            }

            string joinedString = string.Join(" and ", MatchingStrings);
            // Display the string containing the maximum number in label10
            label10.Text = "The best alternatives are: " + joinedString ?? "No matching string found";


        }

        // Recursively calculate sum for each lower node and its child nodes
        double CalculateSum(TreeNode parentNode)
        {
            double sum = 0.0;

            // Get the verjetnost value of the current parent node
            double parentVerjetnost = 0.0;
            if (parentNode.Tag is Vrednosti parentVrednosti)
            {
                parentVerjetnost = parentVrednosti.verjetnost;
            }

            // Traverse through child nodes and extract tag values
            foreach (TreeNode childNode in parentNode.Nodes)
            {
                if (childNode.Tag is Vrednosti vrednosti)
                {
                    // Sum up the vrednosti.vrednost values
                    // Multiply vrednosti.vrednost with vrednosti.verjetnost and add to the sum
                    double value = vrednosti.vrednost * vrednosti.verjetnost;
                    sum += value;

                    //sum += CalculateSum(childNode);
                }

                // Recursive call for nested child nodes
                sum += CalculateSum(childNode);
            }


            double multipliedValue = sum * parentVerjetnost;


            // Update the node's text to display the new tag.vrednost value
            if (parentNode.Nodes.Count > 0)
            {
                string nodeText = parentNode.Text;

                // Find the position of the comma in the node's text
                int commaIndex = nodeText.IndexOf("/");

                if (commaIndex != -1)
                {
                    // Update or add the (SumedUpValue$) part to the node's text
                    nodeText = nodeText.Substring(0, commaIndex + 1) + $"{sum.ToString("0.00$")}";
                }
                else
                {
                    // Add the (SumedUpValue$) part to the node's text
                    nodeText += $"/ {sum.ToString("0.00$")}";
                }

                parentNode.Text = nodeText;
            }

            return multipliedValue;
        }

        private void IzvoziButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TreeView File|*.tvf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Convert the TreeView data to serializable TreeNodeData objects
                List<TreeNodeData> treeData = ConvertTreeViewToSerializableData(Drevo.Nodes);

                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fileStream = File.Create(filePath))
                {
                    formatter.Serialize(fileStream, treeData);
                }

                MessageBox.Show("TreeView saved successfully.", "Success");
            }
        }

        private List<TreeNodeData> ConvertTreeViewToSerializableData(TreeNodeCollection nodes)
        {
            List<TreeNodeData> treeData = new List<TreeNodeData>();
            foreach (TreeNode node in nodes)
            {
                TreeNodeData treeNodeData = new TreeNodeData();
                treeNodeData.Text = node.Text;
                treeNodeData.Tag = (Vrednosti)node.Tag; // Assuming the Tag property is of type Vrednosti
                treeNodeData.Children = ConvertTreeViewToSerializableData(node.Nodes);
                treeData.Add(treeNodeData);
            }
            return treeData;
        }

        // ...

        private void UvoziButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TreeView File|*.tvf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fileStream = File.OpenRead(filePath))
                {
                    List<TreeNodeData> treeData = (List<TreeNodeData>)formatter.Deserialize(fileStream);

                    Drevo.Nodes.Clear();
                    Drevo.Nodes.AddRange(ConvertSerializableDataToTreeView(treeData).ToArray());
                }

                MessageBox.Show("TreeView loaded successfully.", "Success");
            }
        }

        private List<TreeNode> ConvertSerializableDataToTreeView(List<TreeNodeData> treeData)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            foreach (TreeNodeData treeNodeData in treeData)
            {
                TreeNode node = new TreeNode(treeNodeData.Text);
                node.Tag = treeNodeData.Tag; // Assuming the Tag property is of type Vrednosti
                node.Nodes.AddRange(ConvertSerializableDataToTreeView(treeNodeData.Children).ToArray());
                nodes.Add(node);
            }
            return nodes;
        }
    }

}