using System;
using System.Security.Cryptography.X509Certificates;

public class PlayerLevel
{
    private string _playerLevel;
    private string _playerTitle;
    private int _score;
    

    public PlayerLevel(int score)
    {
        _score = score;
        UpdateLevel();
    }
    
    private void UpdateLevel()
    {
        if (_score < 1000)
        {
            _playerLevel = "1";
            _playerTitle = "Apprentice";
        }
        else if (_score < 2000)
        {
            _playerLevel = "2";
            _playerTitle = "Novice";
        }
        else if (_score < 3000)
        {
            _playerLevel = "3";
            _playerTitle = "Adept";
        }
        else if (_score < 4000)
        {
            _playerLevel = "4";
            _playerTitle = "Journeyman";
        }
        else if (_score < 5000)
        {
            _playerLevel = "5";
            _playerTitle = "Master";
        }
        else if (_score < 6000)
        {
            _playerLevel = "6";
            _playerTitle = "Archmage";
        }        
        else if (_score < 7000)
        {
            _playerLevel = "7";
            _playerTitle = "High Wizard";
        }        
        else if (_score < 8000)
        {
            _playerLevel = "8";
            _playerTitle = "Grand Sorcerer";
        }        
        else if (_score < 9000)
        {
            _playerLevel = "9";
            _playerTitle = "Elder Sage";
        }        
        else if (_score < 10000)
        {
            _playerLevel = "10";
            _playerTitle = "Supreme Mage";
        }
    }
    public int GetScore()
    {
        return _score;
    } 
    public void UpdateScore(int score)
    {
        _score = score;
        UpdateLevel();
    }   
    public string GetPlayerInfo()
    {    
        return $"Level: {_playerLevel}\nTitle: {_playerTitle}\nScore: {_score}";
    }
}