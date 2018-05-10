﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
namespace Vivid.Effect
{
   
    public class VEffect
    {
        public Matrix4 LocalMat = Matrix4.Identity;
        public Matrix4 ProjMat = Matrix4.Identity;

        private string _Name = "";
        private string _GShader = "";
        private string _VShader = "";
        private string _FShader = "";
        private int _Program=0;
        private int _Geo=0;
        private int _Vert=0;
        private int _Frag=0;
        public void SetMat(string n,Matrix4 m)
        {
            GL.UniformMatrix4(GL.GetUniformLocation(_Program, n), false,ref m);
        }
        public void SetInt(string n,int v)
        {
            GL.Uniform1(GL.GetUniformLocation(_Program, n), v);
        }
        public void SetFloat(string n,float v)
        {
            GL.Uniform1(GL.GetUniformLocation(_Program, n), v);
        }
        public void SetVec2(string n,Vector2 v)
        {
            GL.Uniform2(GL.GetUniformLocation(_Program, n), ref v);
        }
        public void SetVec3(string n,Vector3 v)
        {
            GL.Uniform3(GL.GetUniformLocation(_Program, n), ref v);
        }
        public void SetVec4(string n,Vector4 v)
        {
            GL.Uniform4(GL.GetUniformLocation(_Program, n), ref v);
        }
        public void SetTex(string n,int i)
        {
            GL.Uniform1(GL.GetUniformLocation(_Program,n), i);
        }
        public void SetBool(string n,bool v)
        {
            GL.Uniform1(GL.GetUniformLocation(_Program, n), v ? 1 : 0);
        }
        public VEffect(string geo="",string vert="",string pix="")
        {
            _GShader = geo;
            _VShader = vert;
            _FShader = pix;
            InitShaders();
        }

        ~VEffect()
        {

         //   GL.DeleteProgram(_Program);

        }
        public virtual void SetPars()
        {

        }
        public bool InitShaders()
        {
            if(_GShader!="")
            {

            }
            if(_VShader!="")
            {
                _Vert = GL.CreateShader(ShaderType.VertexShader);
                GL.ShaderSource(_Vert, File.ReadAllText(@_VShader));
                GL.CompileShader(_Vert);

            }
            Console.WriteLine(GL.GetShaderInfoLog(_Vert));

            if(_FShader!="")
            {
                _Frag = GL.CreateShader(ShaderType.FragmentShader);
                GL.ShaderSource(_Frag, File.ReadAllText(@_FShader));
                GL.CompileShader(_Frag);
            }
            Console.WriteLine(GL.GetShaderInfoLog(_Frag));
            _Program = GL.CreateProgram();

            GL.AttachShader(_Program, _Vert);
            GL.AttachShader(_Program, _Frag);
            GL.LinkProgram(_Program);

          //  GL.DetachShader(_Program, _Vert);
           // GL.DetachShader(_Program, _Frag);
            //GL.DeleteShader(_Vert);
            //GL.DeleteShader(_Frag);


            return true;
        }
        public virtual void Bind()
        {
            GL.UseProgram(_Program);
            SetPars();
        }
        public virtual void Release()
        {
            GL.UseProgram(0);
        }
    }
}
