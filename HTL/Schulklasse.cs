// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using System;
class Schulklasse{
    int Schulstufe;
    string Abteilung;
    string Spezialisierung;
    
    public List<string> Schuelerliste { get; set; }


public void SetOrt(string ort){
    if(Regex.IsMatch(ort, @"^[a-zAäüöÄÖÜß\s]+$")){
    this.ort = ort;
    }
    else{
        Console.WriteLine("Formvorgabe nicht eingehalten: nur Text");
    }
}

public void SetPlz(string plz){
    if(Regex.IsMatch(plz, @"^\d{4}$")){
    this.plz = int.Parse(plz);
    }
    else{
        Console.WriteLine("Formvorgabe nicht eingehalten: nur 4 stellige zahlen");
    }
}
public void SetStrasse(string strasse){
   if(Regex.IsMatch(strasse, @"^[a-zAäüöÄÖÜß\s]+$")){
    this.strasse = strasse;
    }
    else{
        Console.WriteLine("Formvorgabe nicht eingehalten: nur Text");
    }
}
public void SetHausnummer(string hausnummer){
    if(Regex.IsMatch(hausnummer, @"^\d+$")){
    this.hausnummer = int.Parse(hausnummer);
    }
    else{
        Console.WriteLine("Formvorgabe nicht eingehalten: nur zahlen");
    }
}






    public string GetOrt(){
    return ort;
}

public int GetPlz(){
    return plz;
}
public string GetStrasse(){
    return strasse;
}
public int GetHausnummer(){
    return hausnummer;
}


public string Anschrift(){

return $"HTL {ort}\n {strasse}{hausnummer}\n {plz}{ort}";

}

}