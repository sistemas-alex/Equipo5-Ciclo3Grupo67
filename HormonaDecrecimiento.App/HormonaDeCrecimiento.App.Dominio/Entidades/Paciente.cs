namespace HormonaDeCrecimiento.App.Dominio;

public class Paciente:Persona
{
    public int Id{ get; set; }
    public string Direccion{ get; set; }
    public float Latitud{ get; set; }
    public fload Longitud{ get; set; }
    public string Ciudad{ get; set; }
    public DateTime FechaNacimiento{ get; set; }
    public Familiar Familiar{ get; set; }
    public Medico endocrino{ get; set; }
    public Medico pediadra{ get; set; }
    public Historia Historia{ get; set; }
    public System.Collections.Generic.List<PatronCrecimiento>PatronCrecimientos{ get; set;}

}