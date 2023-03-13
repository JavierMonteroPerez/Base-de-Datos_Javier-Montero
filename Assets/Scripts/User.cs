using System;

[Serializable]
public class User
{
    public int ID;
    public string Nombre;
    public string Contraseņa;
    public int Puntuacion;

    //En este script se establecen los valores que luego se guardaran en el Json
    public User(int id, string nombre, string contraseņa, int puntuacion)
    {

        this.ID = id;
        this.Nombre = nombre;
        this.Contraseņa = contraseņa;
        this.Puntuacion = puntuacion;
    }
}
