using GraphicsEditorApp_OOP_course_project.ShapeClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditorApp_OOP_course_project
{
    public partial class Form1: Form
    {
        List<Shape> shapes = new List<Shape>(); //for stage 2
        public Form1()
        {
            InitializeComponent();
        }
    }
}
