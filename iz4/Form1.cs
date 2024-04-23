using System.Formats.Asn1;
using System.Windows.Forms;
using System.Xml.Linq;

namespace iz4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();



            TreeNode rootNode = new TreeNode("1. Вам нравятся компьютерные игры?");
            tv1.Nodes.Add(rootNode);

            TreeNode leaf1 = new TreeNode("Нет");
            rootNode.Nodes.Add(leaf1);

            TreeNode node1 = new TreeNode("2. Вам нравятся настольные игры?");
            leaf1.Nodes.Add(node1);

            TreeNode leaf2 = new TreeNode("Нет");
            node1.Nodes.Add(leaf2);

            TreeNode node2 = new TreeNode("3.Вам нравятся мобильные игры?");
            leaf2.Nodes.Add(node2);

            TreeNode leaf3 = new TreeNode("Нет");
            node2.Nodes.Add(leaf3);

            TreeNode leaf4 = new TreeNode("Мы не можем вам помочь"); ///////////////////////////////////////////
            leaf3.Nodes.Add(leaf4);
            leaf4.Tag = "footzal.jpeg; Футзал. Командный вид спорта, одна из разновидностей футбола, соревнования по которому проводятся под эгидой ФИФА. Другим похожим видом спорта является футбол в залах, или футзал AMF, который проводится под эгидой AMF.";


            TreeNode leaf5 = new TreeNode("Да");
            node2.Nodes.Add(leaf5);

            TreeNode node3 = new TreeNode("23. Вам нравятся шутеры?");
            leaf5.Nodes.Add(node3);

            TreeNode leaf6 = new TreeNode("Да");
            node3.Nodes.Add(leaf6);

            TreeNode node4 = new TreeNode("23. Вам нравятся шутеры?");
            leaf6.Nodes.Add(node4);


            tv1.AfterSelect += tv1_AfterSelect; // Добавляем обработчик события выбора узла

        }

        private void tv1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = tv1.SelectedNode;

            if (selectedNode != null)
            {
                // Очищаем текст Label
                label1.Text = "";

                // Очищаем текст Label для описания (descriptionLabel)
                textBox1.Text = "";

                // Проверяем, является ли узел конечной веткой (без дочерних узлов)
                if (selectedNode.Nodes.Count == 0)
                {
                    pictureBox1.Visible = true;
                    textBox1.Visible = true;
                    string tag = selectedNode.Tag.ToString();
                    string[] tagParts = tag.Split(';');

                    textBox1.Text = "Описание: " + tagParts[1];
                    // Показываем изображение, если узел является конечной веткой
                    string folderPath = "C:\\Users\\azamat\\Desktop\\iz4\\iz4\\pict\\";
                    string fileName = tagParts[0]; ; // Имя файла, добавляем расширение (.jpg)

                    string imagePath = Path.Combine(folderPath, fileName); // Формируем полный путь к файлу


                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Очищаем изображение, если выбрана не конечная ветка
                    pictureBox1.Image = null;
                    pictureBox1.Visible = false;
                    textBox1.Visible = false;
                    // Показываем текст в Label только для вопросов (символ "?")
                    //if (selectedNode.Text.Contains("?"))
                    //{
                    label1.Text = selectedNode.Text;
                    //}
                }

                // Показываем или скрываем чекбоксы в зависимости от количества дочерних узлов
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;


                if (selectedNode.Nodes.Count > 0)
                {
                    // Показываем первый чекбокс и устанавливаем его текст на первый вариант ответа
                    checkBox1.Visible = true;
                    checkBox1.Text = selectedNode.Nodes[0].Text;

                    // Показываем второй чекбокс и устанавливаем его текст на второй вариант ответа (если есть)
                    if (selectedNode.Nodes.Count > 1)
                    {
                        checkBox2.Visible = true;
                        checkBox2.Text = selectedNode.Nodes[1].Text;
                    }

                    // Показываем третий чекбокс и устанавливаем его текст на третий вариант ответа (если есть)
                    if (selectedNode.Nodes.Count > 2)
                    {
                        checkBox3.Visible = true;
                        checkBox3.Text = selectedNode.Nodes[2].Text;
                    }

                    // Показываем третий чекбокс и устанавливаем его текст на четвертый вариант ответа (если есть)
                    if (selectedNode.Nodes.Count > 3)
                    {
                        checkBox4.Visible = true;
                        checkBox4.Text = selectedNode.Nodes[3].Text;
                    }
                }
            }
        }



        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // Получаем выбранный чекбокс
            CheckBox checkBox = (CheckBox)sender;

            // Если чекбокс выбран
            if (checkBox.Checked)
            {
                // Получаем выбранный узел в дереве
                TreeNode selectedNode = tv1.SelectedNode;

                // Если узел не является конечной веткой (с вариантами ответов)
                if (selectedNode.Nodes.Count > 0)
                {
                    // Переходим к следующему вопросу (первому дочернему узлу)
                    tv1.SelectedNode = selectedNode.Nodes[0];
                }

                // Снимаем выделение с чекбоксов после выбора
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Развернуть дерево
            tv1.ExpandAll();
            checkBox1.CheckedChanged += checkBox_CheckedChanged;
            checkBox2.CheckedChanged += checkBox_CheckedChanged;
            checkBox3.CheckedChanged += checkBox_CheckedChanged;
            checkBox4.CheckedChanged += checkBox_CheckedChanged;

            // Выбрать корневую ветку
            tv1.SelectedNode = tv1.Nodes[0]; // Предполагается, что корневая ветка находится на первом индексе

            // Обновить отображение дерева
            tv1.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Переход к следующему узлу после выбора ответа в checkbox1
                TreeNode selectedNode = tv1.SelectedNode;
                if (selectedNode != null && selectedNode.Nodes.Count > 0)
                {
                    TreeNode nextNode = selectedNode.Nodes[0]; // Следующий узел в дереве
                    if (nextNode != null)
                    {
                        tv1.SelectedNode = nextNode;
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                // Переход к следующему узлу после выбора ответа в checkbox2
                TreeNode selectedNode = tv1.SelectedNode;
                if (selectedNode != null && selectedNode.Nodes.Count > 1)
                {
                    TreeNode nextNode = selectedNode.Nodes[1]; // Следующий узел в дереве
                    if (nextNode != null)
                    {
                        tv1.SelectedNode = nextNode;
                    }
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                // Переход к следующему узлу после выбора ответа в checkbox3
                TreeNode selectedNode = tv1.SelectedNode;
                if (selectedNode != null && selectedNode.Nodes.Count > 2)
                {
                    TreeNode nextNode = selectedNode.Nodes[2]; // Следующий узел в дереве
                    if (nextNode != null)
                    {
                        tv1.SelectedNode = nextNode;
                    }
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                // Переход к следующему узлу после выбора ответа в checkbox4
                TreeNode selectedNode = tv1.SelectedNode;
                if (selectedNode != null && selectedNode.Nodes.Count > 3)
                {
                    TreeNode nextNode = selectedNode.Nodes[3]; // Следующий узел в дереве
                    if (nextNode != null)
                    {
                        tv1.SelectedNode = nextNode;
                    }
                }
            }
        }
    }
}