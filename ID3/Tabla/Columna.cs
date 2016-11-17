﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3.Tabla
{
    class Columna
    {
        private int numFilas = 0;
        private List<string> atributos = null;
        private bool isContinuo = false;
        private ArrayList lista;
        
        public Columna(int numFilas, bool isContinuo)
        {
            this.numFilas = numFilas;
            lista = new ArrayList();
            for (int i=0; i<numFilas; i++)
            {
                if (isContinuo == true)
                    lista.Add(0);
                else
                    lista.Add("none");
            }
        }

        public object this[int indice]
        {
            get
            {
                return lista[indice];
            }

            set
            {
                lista[indice] = value;
            }
        }

        public void addAtributo(List<String> attrs)
        {
            this.atributos = attrs;
        }

    }
}