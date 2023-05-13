using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AudioManager : MonoBehaviour
{//Es el encargado de controlar la musica de las escenas.
    static public AudioManager instance;
    private List<GameObject> activeAudioGameObject;
    void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            activeAudioGameObject = new List<GameObject>();
            DontDestroyOnLoad(gameObject);
        }
    }

    public AudioSource PlayAudio(AudioClip clip, float volume = 1) //Para audios de un solo recorrido
    {
        GameObject sourceObj = new GameObject(clip.name);//Crea el objeto
        activeAudioGameObject.Add(sourceObj);//La a�ade ala lista
        sourceObj.transform.SetParent(this.transform);//Crea hijo
        AudioSource source = sourceObj.AddComponent<AudioSource>();//a�ade el componente al objeto nuevo
        source.clip = clip;//
        source.volume = volume;//
        source.Play();//hace el play
        StartCoroutine(PlayAudio(source));//
        return source;
    }
    public AudioSource PlayAudioOnLoop(AudioClip clip, float volume = 1) //Para audios en bucle
    {
        GameObject sourceObj = new GameObject(clip.name);
        activeAudioGameObject.Add(sourceObj);
        sourceObj.transform.SetParent(this.transform);
        AudioSource source = sourceObj.AddComponent<AudioSource>();
        source.clip = clip;
        source.volume = volume;
        source.loop = true;//Le a�ade la funcion de loop.
        source.Play();
        return source;
    }
    public void ClearAudioList()//borra la lista entera para que los aduios no se mezclen entre escenas.
    {
        foreach (GameObject go in activeAudioGameObject)
        {
            Destroy(go);
        }
        activeAudioGameObject.Clear();
    }
    IEnumerator PlayAudio(AudioSource source)
    {
        while (source && source.isPlaying)
        {
            yield return null;
        }
        if (source)
        {
            activeAudioGameObject.Remove(source.gameObject);
            Destroy(source.gameObject);
        }
    }
}
