using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("3 Nephi", 18, 20, 23);
        Scripture scripture = new Scripture(reference, "And whatsoever ye shall ask the Father in my name, which is right, believing that ye shall receive, behold it shall be given unto you. Pray in your families unto the Father, always in my name, that your wives and your children may be blessed. And behold, ye shall meet together oft; and ye shall not forbid any man from coming unto you when ye shall meet together, but suffer them that they may come unto you and forbid them not; But ye shall pray for them, and shall not cast them out; and if it so be that they come unto you oft ye shall pray for them unto the Father, in my name.");
        
        while(!scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' do finish");
            string input = Console.ReadLine();
            if(input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                Console.Clear();
                scripture.HideRandomWords(3);
            }
        }

        
    }
}