using System;

namespace Palindromes
{
  public class Game
  {
    private string _word;
    public Game(string word)
    {
      _word = word;
    }
    public Game(int word)
    {
      _word = word.ToString();
    }
    public bool Palin()
    {
      char[] characters = _word.ToCharArray();
      Array.Reverse(characters);
      if(string.Join("", characters) == _word)
      {
        return true;
      }else{
        return false;
      }
    }
    public bool PalinHard()
    {
      char[] characters = _word.ToCharArray();
      for(int i=0; i<characters.Length; i++){
        if(characters[i] != characters[characters.Length-i-1])
        {
          return false;
        }
      }
      return true;
    }
  }
}
