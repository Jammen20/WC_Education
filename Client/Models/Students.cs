using System;

namespace Client.Models;

public class Students
{
    public string FirstName { get; set; } = "";
    public string SurName { get; set; } = "";
    public string Phone { get; set; } = "";
    public string? PersonNmr { get; set; } = "";
    public string AddressLine { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string City { get; set; } = "";

    public override string ToString()
    {
        return $" Förnamn: {FirstName} \n Efternamn: {SurName} \n Telefon: {Phone} \n Personnummer: {PersonNmr} \n Adress: {AddressLine} \n Postkod: {PostalCode} \n Stad: {City} \n";
    }
}
