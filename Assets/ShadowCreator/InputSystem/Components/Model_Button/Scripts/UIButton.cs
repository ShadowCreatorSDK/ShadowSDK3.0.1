﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


namespace SC
{
	[RequireComponent(typeof(BoxCollider))]

	[AddComponentMenu("ShadowCreator/UIButton")]
	public class UIButton : Button{


        public static AudioClip clickAudio;
        public static AudioClip enterAudio;

        private AudioSource mAudioSource;
        enum AudioType {
            Enter,
            Click,
        }

        protected override void Awake() {
            base.Awake();
            clickAudio = Resources.Load<AudioClip>("Sound/btnSound");
            enterAudio = Resources.Load<AudioClip>("Sound/mouseOver");
            mAudioSource = GetComponent<AudioSource>();
            if(!mAudioSource) {
                mAudioSource = gameObject.AddComponent<AudioSource>();
                mAudioSource.playOnAwake = false;
            }
        }

        void PlayAudio( AudioType type ) {
            if(type == AudioType.Click && clickAudio) {
                mAudioSource.clip = clickAudio;
                mAudioSource.Play();
            } else if(type == AudioType.Enter && enterAudio) {
                mAudioSource.clip = enterAudio;
                mAudioSource.Play();
            }
        }

        public override void OnPointerClick( PointerEventData eventData ) {
            base.OnPointerClick(eventData);
            PlayAudio(AudioType.Click);
        }




    }
}

