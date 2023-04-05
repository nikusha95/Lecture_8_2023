namespace Generics;

public class AnimalShelterGeneric<T>
{
    private const int DefaultPlacesCount = 20;
    private readonly T[] _animalList;

    private int _usedPlaces;


    public AnimalShelterGeneric() : this(DefaultPlacesCount)
    {
    }


    public AnimalShelterGeneric(int placesCount)
    {
        _animalList = new T[placesCount];

        _usedPlaces = 0;
    }


    public void Shelter(T newAnimal)

    {
        if (_usedPlaces >= _animalList.Length)
        {
            Console.WriteLine("Invalid index");
            return;
        }

        _animalList[_usedPlaces] = newAnimal;

        _usedPlaces++;
    }


    public T Release(int index)

    {
        if (index < 0 || index >= this._usedPlaces)

        {
            throw new ArgumentOutOfRangeException(
                "Invalid cell index: " + index);
        }

        T releasedAnimal = _animalList[index];

        for (int i = index; i < _usedPlaces - 1; i++)

        {
            _animalList[i] = _animalList[i + 1];
        }

        _animalList[_usedPlaces - 1] = (default);

        _usedPlaces--;


        return releasedAnimal;
    }
}