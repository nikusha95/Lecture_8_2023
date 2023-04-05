namespace Generics;

public class AnimalShelter
{
    private const int DefaultPlacesCount = 20;


    private readonly Dog[] _animalList;

    private int _usedPlaces;


    public AnimalShelter() : this(DefaultPlacesCount)

    {
    }


    public AnimalShelter(int placesCount)

    {
        _animalList = new Dog[placesCount];

        _usedPlaces = 0;
    }


    public void Shelter(Dog newAnimal)

    {
        if (_usedPlaces >= _animalList.Length)
        {
            Console.WriteLine("Invalid index");
            return;
        }

        _animalList[_usedPlaces] = newAnimal;

        _usedPlaces++;
    }


    public Dog Release(int index)

    {
        if (index < 0 || index >= this._usedPlaces)

        {
            throw new ArgumentOutOfRangeException(
                "Invalid cell index: " + index);
        }

        Dog releasedAnimal = this._animalList[index];

        for (int i = index; i < this._usedPlaces - 1; i++)

        {
            _animalList[i] = this._animalList[i + 1];
        }

        _animalList[_usedPlaces - 1] = null;

        _usedPlaces--;


        return releasedAnimal;
    }
}