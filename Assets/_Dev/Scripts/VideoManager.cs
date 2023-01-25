using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour
{

    [SerializeField] RawImage rawImage;
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] VideoClip[] videoClips;

    public bool disable;

    void Awake(){
        videoPlayer.loopPointReached += OverVideo;
    }

    void Start(){
        rawImage.color = new Color(255,255,255,0);
    }


    public void PlayVideo(int video){
        rawImage.color = new Color(255,255,255,255);
        videoPlayer.clip = videoClips[video];
        videoPlayer.Play();

    }

    void OverVideo(VideoPlayer vp){
        videoPlayer.clip = null;
        rawImage.color = new Color(255,255,255,0);
        this.gameObject.SetActive(false);
    }
}
