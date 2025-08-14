using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o domínio para verificar (ex: @gmail.com):");
        string dominio = Console.ReadLine();
        Console.WriteLine("Digite os emails separados por vírgula:");
        string[] emails = Console.ReadLine().Split(',');

        VerificarEmail(emails, dominio);
    }
    static void VerificarEmail(string[] emails, string dominio)
    {
        List<string> emailsVerificados = new List<string>();

        foreach (string email in emails)
        {
            string emailTrim = email.Trim();

            if (email.Length > dominio.Length)
            {
                if (emailTrim.EndsWith(dominio))
                    emailsVerificados.Add(emailTrim);
            }
        }

        Console.WriteLine("Emails verificados com sucesso:");
        foreach (string email in emailsVerificados)
        {
            Console.WriteLine(email);
        }
    }
}
