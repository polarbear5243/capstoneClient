S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 12774
Date: 2017-04-01 22:46:40+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 12774, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb27c3e79
r2   = 0xbefdbf30, r3   = 0x00000048
r4   = 0xb3f9ba3c, r5   = 0xbefdc484
r6   = 0x00000001, r7   = 0xbefdc308
r8   = 0xb40944c0, r9   = 0xb868fa28
r10  = 0xb678d000, fp   = 0xbefdbf1c
ip   = 0xb669e724, sp   = 0xbefdb9e8
lr   = 0xb669e740, pc   = 0xb6695158
cpsr = 0x600d0010

Memory Information
MemTotal:   987012 KB
MemFree:    134008 KB
Buffers:     50160 KB
Cached:     282840 KB
VmPeak:      98488 KB
VmSize:      98484 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19440 KB
VmRSS:       19440 KB
VmData:      30108 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35644 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 12774 TID = 12774
12774 12775 13455 13456 

Maps Information
b136e000 b1376000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1388000 b1b87000 rw-p [stack:13456]
b1b87000 b1b88000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b98000 b1bac000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bc0000 b1bc1000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bd1000 b1bd4000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1be5000 b1be6000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bf6000 b1bf8000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c08000 b1c0a000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c1a000 b1c2a000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c3a000 b1c46000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c58000 b2457000 rw-p [stack:13455]
b2788000 b278f000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27a2000 b27a8000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27b8000 b27c8000 r-xp /opt/usr/apps/org.example.client/bin/client
b2920000 b2a03000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a3a000 b2a62000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a74000 b3273000 rw-p [stack:12775]
b3273000 b3275000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3285000 b328f000 r-xp /lib/libnss_files-2.20-2014.11.so
b32a0000 b32a9000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32ba000 b32cb000 r-xp /lib/libnsl-2.20-2014.11.so
b32de000 b32e4000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32f5000 b32f6000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b331e000 b3325000 r-xp /usr/lib/libminizip.so.1.0.0
b3335000 b333a000 r-xp /usr/lib/libstorage.so.0.1
b334a000 b33a9000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33bf000 b33d3000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33e3000 b3427000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3437000 b343f000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b344f000 b347f000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3492000 b354b000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b355f000 b35b2000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35c3000 b35de000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35ee000 b36af000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36c2000 b36d2000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36e2000 b36ef000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3700000 b3707000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3717000 b3758000 r-xp /usr/lib/libmdm.so.1.2.12
b3768000 b3770000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b377f000 b378f000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37b0000 b3810000 r-xp /usr/lib/libasound.so.2.0.0
b3822000 b3825000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3835000 b3838000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3848000 b384d000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b385d000 b385e000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b386e000 b3879000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b388d000 b3894000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38a4000 b38aa000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38ba000 b38bf000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38cf000 b38ea000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38fa000 b3901000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3911000 b3914000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3925000 b3953000 r-xp /usr/lib/libidn.so.11.5.44
b3963000 b3979000 r-xp /usr/lib/libnghttp2.so.5.4.0
b398a000 b3994000 r-xp /usr/lib/libcares.so.2.1.0
b39a4000 b39ae000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39be000 b39c0000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39d0000 b39d1000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39e1000 b39e5000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39f6000 b3a1e000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a2f000 b3a58000 r-xp /usr/lib/libturbojpeg.so
b3a78000 b3a7e000 r-xp /usr/lib/libgif.so.4.1.6
b3a8e000 b3ad4000 r-xp /usr/lib/libcurl.so.4.3.0
b3ae5000 b3b06000 r-xp /usr/lib/libexif.so.12.3.3
b3b21000 b3b36000 r-xp /usr/lib/libtts.so
b3b47000 b3b4f000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b5f000 b3c25000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c45000 b3d3d000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d5c000 b3e2a000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e41000 b3e43000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e53000 b3e59000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e69000 b3e8c000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e9d000 b3e9f000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eaf000 b3eb1000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ec2000 b3ec7000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ede000 b3ee0000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ef0000 b3ef7000 r-xp /usr/lib/libsensord-share.so
b3f07000 b3f1f000 r-xp /usr/lib/libsensor.so.1.1.0
b3f30000 b3f33000 r-xp /usr/lib/libXv.so.1.0.0
b3f43000 b3f48000 r-xp /usr/lib/libutilX.so.1.1.0
b3f58000 b3f5d000 r-xp /usr/lib/libappcore-common.so.1.1
b3f6d000 b3f74000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f87000 b3f8b000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f9c000 b407a000 r-xp /usr/lib/libCOREGL.so.4.0
b409a000 b409d000 r-xp /usr/lib/libuuid.so.1.3.0
b40ad000 b40c4000 r-xp /usr/lib/libblkid.so.1.1.0
b40d5000 b40d7000 r-xp /usr/lib/libXau.so.6.0.0
b40e7000 b412e000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4140000 b4146000 r-xp /usr/lib/libjson-c.so.2.0.1
b4157000 b415b000 r-xp /usr/lib/libogg.so.0.7.1
b416b000 b418d000 r-xp /usr/lib/libvorbis.so.0.4.3
b419d000 b4281000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b429d000 b42a0000 r-xp /usr/lib/libEGL.so.1.4
b42b1000 b42b7000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42c7000 b42c9000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42d9000 b42e6000 r-xp /usr/lib/libGLESv2.so.2.0
b42f7000 b4359000 r-xp /usr/lib/libpixman-1.so.0.28.2
b436e000 b4386000 r-xp /usr/lib/libmount.so.1.1.0
b4398000 b43ac000 r-xp /usr/lib/libxcb.so.1.1.0
b43bc000 b43c3000 r-xp /lib/libcrypt-2.20-2014.11.so
b43fb000 b43fd000 r-xp /usr/lib/libiri.so
b440d000 b4418000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4429000 b445f000 r-xp /usr/lib/libpulse.so.0.16.2
b4470000 b44b3000 r-xp /usr/lib/libsndfile.so.1.0.25
b44c8000 b44dd000 r-xp /lib/libexpat.so.1.5.2
b44ef000 b45ad000 r-xp /usr/lib/libcairo.so.2.11200.14
b45c1000 b45c9000 r-xp /usr/lib/libdrm.so.2.4.0
b45d9000 b45dc000 r-xp /usr/lib/libdri2.so.0.0.0
b45ec000 b463a000 r-xp /usr/lib/libssl.so.1.0.0
b464f000 b465b000 r-xp /usr/lib/libeeze.so.1.13.0
b466c000 b4675000 r-xp /usr/lib/libethumb.so.1.13.0
b4685000 b4688000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4698000 b484f000 r-xp /usr/lib/libcrypto.so.1.0.0
b563a000 b5643000 r-xp /usr/lib/libXi.so.6.1.0
b5653000 b5655000 r-xp /usr/lib/libXgesture.so.7.0.0
b5665000 b5669000 r-xp /usr/lib/libXtst.so.6.1.0
b5679000 b567f000 r-xp /usr/lib/libXrender.so.1.3.0
b568f000 b5695000 r-xp /usr/lib/libXrandr.so.2.2.0
b56a5000 b56a7000 r-xp /usr/lib/libXinerama.so.1.0.0
b56b8000 b56bb000 r-xp /usr/lib/libXfixes.so.3.1.0
b56cb000 b56d6000 r-xp /usr/lib/libXext.so.6.4.0
b56e6000 b56e8000 r-xp /usr/lib/libXdamage.so.1.1.0
b56f8000 b56fa000 r-xp /usr/lib/libXcomposite.so.1.0.0
b570a000 b57ec000 r-xp /usr/lib/libX11.so.6.3.0
b5800000 b5807000 r-xp /usr/lib/libXcursor.so.1.0.2
b5817000 b582f000 r-xp /usr/lib/libudev.so.1.6.0
b5831000 b5834000 r-xp /lib/libattr.so.1.1.0
b5844000 b5864000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5865000 b586a000 r-xp /usr/lib/libffi.so.6.0.2
b587b000 b5893000 r-xp /lib/libz.so.1.2.8
b58a3000 b58a5000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58b5000 b598a000 r-xp /usr/lib/libxml2.so.2.9.2
b599f000 b5a3a000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a56000 b5a59000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a69000 b5a82000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a93000 b5aa4000 r-xp /lib/libresolv-2.20-2014.11.so
b5ab8000 b5b32000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b47000 b5b49000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b59000 b5b60000 r-xp /usr/lib/libembryo.so.1.13.0
b5b70000 b5b7a000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b8b000 b5ba3000 r-xp /usr/lib/libpng12.so.0.50.0
b5bb4000 b5bd7000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bf8000 b5c0c000 r-xp /usr/lib/libector.so.1.13.0
b5c1d000 b5c35000 r-xp /usr/lib/liblua-5.1.so
b5c46000 b5c9d000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cb1000 b5cd9000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cea000 b5cfd000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d0e000 b5d48000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d59000 b5d67000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d77000 b5d7f000 r-xp /usr/lib/libtbm.so.1.0.0
b5d8f000 b5d9c000 r-xp /usr/lib/libeio.so.1.13.0
b5dac000 b5dae000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dbe000 b5dc3000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dd3000 b5dea000 r-xp /usr/lib/libefreet.so.1.13.0
b5dfc000 b5e1c000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e2c000 b5e4c000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e4e000 b5e54000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e64000 b5e75000 r-xp /usr/lib/libemotion.so.1.13.0
b5e86000 b5e8d000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e9d000 b5eac000 r-xp /usr/lib/libeo.so.1.13.0
b5ebd000 b5ecf000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ee0000 b5ee5000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ef5000 b5f0e000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f1e000 b5f3b000 r-xp /usr/lib/libeet.so.1.13.0
b5f54000 b5f9c000 r-xp /usr/lib/libeina.so.1.13.0
b5fad000 b5fbd000 r-xp /usr/lib/libefl.so.1.13.0
b5fce000 b60b3000 r-xp /usr/lib/libicuuc.so.51.1
b60d0000 b6210000 r-xp /usr/lib/libicui18n.so.51.1
b6227000 b625f000 r-xp /usr/lib/libecore_x.so.1.13.0
b6271000 b6274000 r-xp /lib/libcap.so.2.21
b6284000 b62ad000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62be000 b62c5000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62d7000 b630e000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b631f000 b640a000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b641d000 b6496000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64a8000 b64ad000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64bd000 b64c7000 r-xp /usr/lib/libvconf.so.0.2.45
b64d7000 b64d9000 r-xp /usr/lib/libvasum.so.0.3.1
b64e9000 b64eb000 r-xp /usr/lib/libttrace.so.1.1
b64fb000 b64fe000 r-xp /usr/lib/libiniparser.so.0
b650e000 b6534000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6544000 b6549000 r-xp /usr/lib/libxdgmime.so.1.1.0
b655a000 b6571000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6582000 b65ed000 r-xp /lib/libm-2.20-2014.11.so
b65fe000 b6604000 r-xp /lib/librt-2.20-2014.11.so
b6615000 b6622000 r-xp /usr/lib/libunwind.so.8.0.1
b6658000 b677c000 r-xp /lib/libc-2.20-2014.11.so
b6791000 b67aa000 r-xp /lib/libgcc_s-4.9.so.1
b67ba000 b689c000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68ad000 b68d7000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68e8000 b6924000 r-xp /usr/lib/libsystemd.so.0.4.0
b6926000 b69a9000 r-xp /usr/lib/libedje.so.1.13.0
b69bc000 b69da000 r-xp /usr/lib/libecore.so.1.13.0
b69fa000 b6b81000 r-xp /usr/lib/libevas.so.1.13.0
b6bb6000 b6bca000 r-xp /lib/libpthread-2.20-2014.11.so
b6bde000 b6e12000 r-xp /usr/lib/libelementary.so.1.13.0
b6e41000 b6e45000 r-xp /usr/lib/libsmack.so.1.0.0
b6e55000 b6e5c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e6c000 b6e6e000 r-xp /usr/lib/libdlog.so.0.0.0
b6e7e000 b6e81000 r-xp /usr/lib/libbundle.so.0.1.22
b6e91000 b6e93000 r-xp /lib/libdl-2.20-2014.11.so
b6ea4000 b6ebc000 r-xp /usr/lib/libaul.so.0.1.0
b6ed0000 b6ed5000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ee6000 b6ef3000 r-xp /usr/lib/liblptcp.so
b6f05000 b6f09000 r-xp /usr/lib/libsys-assert.so
b6f1a000 b6f3a000 r-xp /lib/ld-2.20-2014.11.so
b6f4b000 b6f50000 r-xp /usr/bin/launchpad-loader
b8650000 b887b000 rw-p [heap]
befbc000 befdd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12774)
Call Stack Count: 15
 0: _IO_vfprintf + 0x28 (0xb6695158) [/lib/libc.so.6] + 0x3d158
 1: _IO_fprintf + 0x1c (0xb669e740) [/lib/libc.so.6] + 0x46740
 2:  + 0x0 (0xb27bba8f) [/opt/usr/apps/org.example.client/bin/client] + 0x3a8f
 3: _ZN7MyLoginC2EP9Naviframe + 0x48 (0xb27bb9d1) [/opt/usr/apps/org.example.client/bin/client] + 0x39d1
 4: _ZN8MyWindow8onCreateEv + 0x110 (0xb27bb805) [/opt/usr/apps/org.example.client/bin/client] + 0x3805
 5: _ZN6Window10app_createEPv + 0x8e (0xb27c123b) [/opt/usr/apps/org.example.client/bin/client] + 0x923b
 6: _ZN6Window17static_app_createEPv + 0x24 (0xb27c13b5) [/opt/usr/apps/org.example.client/bin/client] + 0x93b5
 7: (0xb3f894f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 8: appcore_efl_main + 0x152 (0xb6ed3203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 9: ui_app_main + 0xc0 (0xb3f89909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
10: _ZN6Window10makeWindowEiPPc + 0x11e (0xb27c173f) [/opt/usr/apps/org.example.client/bin/client] + 0x973f
11: main + 0x40 (0xb27bb58d) [/opt/usr/apps/org.example.client/bin/client] + 0x358d
12: (0xb6f4cbb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
13: __libc_start_main + 0x114 (0xb666e4bc) [/lib/libc.so.6] + 0x164bc
14: (0xb6f4ceb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x800e2965 into part 'tizen_vg_shape2'
04-01 22:46:14.580+0900 I/MALI    (10946): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=10946   close drm_fd=30 
04-01 22:46:14.741+0900 I/UXT     (13191): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-01 22:46:14.761+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(11624): preference_inoti.c: _preference_kdb_del_notify(372) > _preference_kdb_del_notify : Key(BookmarkSelectFolderPathTree) does not exist
04-01 22:46:14.761+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(11624): preference.c: preference_unset_changed_cb(1487) > NO_KEY(0xfef00030) : fail to find given key(BookmarkSelectFolderPathTree)
04-01 22:46:14.761+0900 W/BROWSER_PROVIDER(12971): browser-provider-requests-manager.c: bp_thread_requests_manager(698) > new-client[TABS:2044460146] slot:0 sock:7
04-01 22:46:14.771+0900 W/BROWSER_PROVIDER(12971): browser-provider-requests-manager.c: __handle_client_request(357) > client(TABS:2044460146) sock:7 req(DUP_ORDER_IDS:-1)
04-01 22:46:14.771+0900 W/BROWSER_PROVIDER(12971): browser-provider-requests-manager.c: __handle_client_request(357) > client(TABS:2044460146) sock:7 req(GET_INFO_OFFSET:1907916453)
04-01 22:46:14.771+0900 W/BROWSER_PROVIDER(12971): browser-provider-requests-manager.c: __handle_client_request(357) > client(TABS:2044460146) sock:7 req(DEINIT:-1)
04-01 22:46:14.771+0900 E/Internet(11624): mdm-manager.cpp: deregister_policy(271) > mdm_deregister_policy_receiver() is failed [0xc0000000]
04-01 22:46:14.771+0900 E/Internet(11624): mdm-manager.cpp: deregister_policy(275) > mdm_release_service failed
04-01 22:46:14.771+0900 E/BROWSER_PROVIDER(12971): browser-provider-socket.c: bp_ipc_recv(56) > [ERROR] __handle_client_request closed peer sock:7
04-01 22:46:14.771+0900 E/BROWSER_PROVIDER(12971): browser-provider-requests-manager.c: client_thread_idle(481) > disconnect client:TABS/2044460146 sock:7
04-01 22:46:14.781+0900 E/Internet(11624): browser.cpp: terminate_app_launch_request(2250) > m_appControl is NULL
04-01 22:46:14.811+0900 E/VCONF   (11624): vconf-kdb.c: _vconf_kdb_del_notify(468) > Error: inotify_add_watch() [/var/run/memory/popsync+popsync_activated]: No such file or directory
04-01 22:46:14.841+0900 E/TBM     (13191): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-01 22:46:14.841+0900 I/MALI    (13191): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=13191   open drm_fd=30 
04-01 22:46:14.851+0900 I/MALI    (11624): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=11624   close drm_fd=30 
04-01 22:46:14.871+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10946 pgid = 10946
04-01 22:46:14.871+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(143) > dead_pid(10946)
04-01 22:46:14.891+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-01 22:46:14.891+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-01 22:46:14.891+0900 E/AUL_PAD ( 1508): launchpad.c: main(698) > error reading sigchld info
04-01 22:46:14.901+0900 I/ESD     (  913): esd_main.c: __esd_app_dead_handler(1773) > pid: 10946
04-01 22:46:14.901+0900 I/Tizen::App( 1247): (243) > App[com.samsung.myfile-lite] pid[10946] terminate event is forwarded
04-01 22:46:14.901+0900 I/Tizen::System( 1247): (256) > osp.accessorymanager.service provider is found.
04-01 22:46:14.901+0900 I/Tizen::System( 1247): (196) > Accessory Owner is removed [com.samsung.myfile-lite, 10946, ]
04-01 22:46:14.901+0900 I/Tizen::System( 1247): (256) > osp.system.service provider is found.
04-01 22:46:14.901+0900 I/Tizen::App( 1247): (506) > TerminatedApp(com.samsung.myfile-lite)
04-01 22:46:14.901+0900 I/Tizen::App( 1247): (512) > Not registered pid(10946)
04-01 22:46:14.901+0900 I/Tizen::System( 1247): (246) > Terminated app [com.samsung.myfile-lite]
04-01 22:46:14.901+0900 I/Tizen::Io( 1247): (729) > Entry not found
04-01 22:46:14.901+0900 W/AUL_AMD (  605): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10946
04-01 22:46:14.901+0900 E/RESOURCED(  685): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.999
04-01 22:46:14.911+0900 I/Tizen::System( 1247): (157) > change brightness system value.
04-01 22:46:14.911+0900 I/Tizen::App( 1247): (782) > Finished invoking application event listener for com.samsung.myfile-lite, 10946.
04-01 22:46:15.011+0900 E/EFL     (13191): edje<13191> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-01 22:46:15.011+0900 E/EFL     (13191): By the power of Grayskull, your previous Embryo stack is now broken!
04-01 22:46:15.011+0900 E/EFL     (13191): edje<13191> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-01 22:46:15.011+0900 E/EFL     (13191): By the power of Grayskull, your previous Embryo stack is now broken!
04-01 22:46:15.011+0900 E/EFL     (13191): edje<13191> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-01 22:46:15.011+0900 E/EFL     (13191): By the power of Grayskull, your previous Embryo stack is now broken!
04-01 22:46:15.051+0900 I/CAPI_NETWORK_CONNECTION(11624): connection.c: connection_destroy(427) > Destroy handle: 0xb8c36678
04-01 22:46:15.051+0900 I/CAPI_NETWORK_CONNECTION(11624): connection.c: __connection_set_ip_changed_callback(266) > Successfully de-registered(0)
04-01 22:46:15.051+0900 I/CAPI_NETWORK_CONNECTION(11624): connection.c: __connection_set_proxy_changed_callback(351) > Successfully de-registered(0)
04-01 22:46:15.051+0900 E/WEBKIT  (11624): static void Ewk_Geolocation_Provider::stopUpdating(WKGeolocationManagerRef, const void*)(201) > ERROR: already stopped or not started
04-01 22:46:15.091+0900 E/BROWSER_PROVIDER(12971): browser-provider-socket.c: bp_ipc_recv(56) > [ERROR] __handle_client_request closed peer sock:17
04-01 22:46:15.091+0900 E/BROWSER_PROVIDER(12971): browser-provider-requests-manager.c: client_thread_idle(481) > disconnect client:BOOKMARK_CSC/1408513869 sock:17
04-01 22:46:15.091+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 11624 pgid = 11624
04-01 22:46:15.091+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(143) > dead_pid(11624)
04-01 22:46:15.121+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-01 22:46:15.121+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-01 22:46:15.121+0900 E/AUL_PAD ( 1508): launchpad.c: main(698) > error reading sigchld info
04-01 22:46:15.121+0900 I/ESD     (  913): esd_main.c: __esd_app_dead_handler(1773) > pid: 11624
04-01 22:46:15.121+0900 I/Tizen::App( 1247): (243) > App[com.samsung.browser] pid[11624] terminate event is forwarded
04-01 22:46:15.121+0900 W/AUL_AMD (  605): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 11624
04-01 22:46:15.121+0900 I/Tizen::System( 1247): (256) > osp.accessorymanager.service provider is found.
04-01 22:46:15.121+0900 I/Tizen::System( 1247): (196) > Accessory Owner is removed [com.samsung.browser, 11624, ]
04-01 22:46:15.121+0900 I/Tizen::System( 1247): (256) > osp.system.service provider is found.
04-01 22:46:15.121+0900 I/Tizen::App( 1247): (506) > TerminatedApp(com.samsung.browser)
04-01 22:46:15.121+0900 I/Tizen::App( 1247): (512) > Not registered pid(11624)
04-01 22:46:15.121+0900 I/Tizen::System( 1247): (246) > Terminated app [com.samsung.browser]
04-01 22:46:15.121+0900 I/Tizen::Io( 1247): (729) > Entry not found
04-01 22:46:15.121+0900 E/RESOURCED(  685): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1000
04-01 22:46:15.131+0900 I/Tizen::System( 1247): (157) > change brightness system value.
04-01 22:46:15.131+0900 I/Tizen::App( 1247): (782) > Finished invoking application event listener for com.samsung.browser, 11624.
04-01 22:46:17.063+0900 E/AUL_AMD (  605): amd_launch.c: __reply_handler(1059) > recv error : Connection reset by peer
04-01 22:46:17.063+0900 W/AUL_AMD (  605): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(12901), cmd(4)
04-01 22:46:17.063+0900 W/AUL     (12981): launch.c: app_request_to_launchpad(425) > request cmd(4) result(-1)
04-01 22:46:17.063+0900 E/TASK_MGR_LITE(12981): recent_apps.c: kill_pid(87) > kill pid: 12901 (Permission denied)
04-01 22:46:17.093+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 22:46:17.093+0900 W/AUL_AMD (  605): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 11099
04-01 22:46:17.093+0900 W/AUL     (12981): launch.c: app_request_to_launchpad(396) > request cmd(4) to(11099)
04-01 22:46:17.093+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 4
04-01 22:46:17.093+0900 W/AUL_AMD (  605): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(11099), cmd(4)
04-01 22:46:17.103+0900 I/APP_CORE(11099): appcore-efl.c: __do_app(514) > [APP 11099] Event: TERMINATE State: PAUSED
04-01 22:46:17.103+0900 W/AUL     (12981): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
04-01 22:46:17.103+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 22
04-01 22:46:17.103+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(1201) > app status : 5
04-01 22:46:17.103+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 22
04-01 22:46:17.103+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(1201) > app status : 5
04-01 22:46:17.123+0900 E/TASK_MGR_LITE(12981): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
04-01 22:46:17.133+0900 I/TIZEN_N_EFL_UTIL_WINDOW(11099): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 27
04-01 22:46:17.133+0900 E/APP_CORE(11099): appcore-efl.c: _capture_and_make_file(1619) > win[6400003] widget[720] height[1280]
04-01 22:46:17.143+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 33
04-01 22:46:17.143+0900 E/APP_CORE(11099): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [com.samsung.contacts]
04-01 22:46:17.153+0900 I/CAPI_APPFW_APPLICATION(11099): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-01 22:46:17.153+0900 I/WAPP    (11099): WApp.cpp: __onTerminate(64) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.153+0900 I/PHONE   (11099): ContactsApp.cpp: onTerminate(169) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.153+0900 I/PHONE   (11099): ContactsCommon.cpp: unsetChangeableTable(363) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.153+0900 I/WAPP    (11099): WNaviframe.cpp: destroy(139) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.153+0900 I/WAPP    (11099): WNaviframe.cpp: destroyAllViews(199) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.163+0900 E/APP_CORE(12981): appcore.c: appcore_flush_memory(793) > Appcore not initialized
04-01 22:46:17.163+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 22:46:17.183+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(878) status(3)
04-01 22:46:17.183+0900 W/AUL_AMD (  605): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-01 22:46:17.183+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-01 22:46:17.183+0900 W/AUL     (  605): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(878)
04-01 22:46:17.183+0900 W/AUL     (  605): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 878, appid: com.samsung.homescreen, status: fg
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 10
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 30
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 10
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 30
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 10
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 30
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 10
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 30
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 10
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 30
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 10
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 30
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 10
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 30
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 10
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 30
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 10
04-01 22:46:17.183+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 30
04-01 22:46:17.203+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(878) status(0)
04-01 22:46:17.213+0900 I/WAPP    (11099): WView.cpp: __objDelCb(73) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.213+0900 I/PHONE   (11099): CtTabView.cpp: ~CtTabView(95) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.213+0900 I/PHONE   (11099): CtThemeMgr.cpp: CtThemeMgr(34) > [0;32mBEGIN >>>>[0;m
04-01 22:46:17.243+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 22:46:17.243+0900 I/APP_CORE(  878): appcore-efl.c: __do_app(514) > [APP 878] Event: RESUME State: PAUSED
04-01 22:46:17.243+0900 I/CAPI_APPFW_APPLICATION(  878): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-01 22:46:17.243+0900 E/cluster-home(  878): homescreen.cpp: OnResume(233) >  app resume
04-01 22:46:17.243+0900 I/PHONE   (11099): CtThemeMgr.cpp: destroy(54) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.243+0900 I/PHONE   (11099): CtThemeMgr.cpp: ~CtThemeMgr(42) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.253+0900 I/PHONE   (11099): CtSimMgr.cpp: __updateSimInsertState(175) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.253+0900 I/MALI    (12981): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=12981   close drm_fd=30 
04-01 22:46:17.263+0900 E/weather-widget( 1420): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-01 22:46:17.283+0900 I/PHONE   (11099): CtSimMgr.cpp: __updateSimEnableState(119) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.293+0900 I/Tizen::System( 1247): (259) > Active app [com.samsun], current [com.samsun] 
04-01 22:46:17.293+0900 I/Tizen::System( 1247): (273) > Current App[com.samsun] is already actived.
04-01 22:46:17.293+0900 E/PHONE   (11099): CtSimMgr.cpp: __updateSimId(302) > [0;31m* Critical * tel_get_sim_imsi() is failed[0;m
04-01 22:46:17.293+0900 I/PHONE   (11099): CtSimMgr.cpp: __updatePreferredSim(216) > [0;32mBEGIN >>>>[0;m
04-01 22:46:17.313+0900 I/PHONE   (11099): CtSimMgr.cpp: __setSimChangeCallback(598) > [0;32mBEGIN >>>>[0;m
04-01 22:46:17.313+0900 I/PHONE   (11099): CtSimMgr.cpp: destroy(62) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.313+0900 I/PHONE   (11099): CtSimMgr.cpp: ~CtSimMgr(53) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.313+0900 I/PHONE   (11099): CtSimMgr.cpp: __unsetSimChangeCallback(633) > [0;32mBEGIN >>>>[0;m
04-01 22:46:17.313+0900 I/WAPP    (11099): WView.cpp: ~WView(111) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.333+0900 I/WAPP    (11099): WView.cpp: __objDelCb(73) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.333+0900 I/PHONE   (11099): PhDialerView.cpp: onDestroy(141) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.333+0900 W/CALL_MGR_CLIENT(11099): <LIB:__cm_evt_list_key_destroyed_cb:345> Key[/org/tizen/callmgr:org.tizen.callmgr:CallEvent] is removed from hash table.
04-01 22:46:17.343+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 15
04-01 22:46:17.343+0900 E/weather-widget( 1420): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-01 22:46:17.353+0900 I/PHONE   (11099): PhDialerView.cpp: ~PhDialerView(53) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.353+0900 I/PHONE   (11099): PhDialerKeypadLayoutControl.cpp: onDestroy(96) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.353+0900 I/PHONE   (11099): PhDialerKeypadLayoutControl.cpp: ~PhDialerKeypadLayoutControl(70) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.353+0900 I/PHONE   (11099): PhDialerKeypadControl.cpp: onDestroy(115) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.353+0900 I/PHONE   (11099): PhDialerKeypadControl.cpp: __unregisterListener(480) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.363+0900 E/weather-common( 1420): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-01 22:46:17.383+0900 I/CAPI_NETWORK_CONNECTION( 1420): connection.c: connection_create(409) > New handle created[0xb8c10ef0]
04-01 22:46:17.383+0900 I/CAPI_NETWORK_CONNECTION( 1420): connection.c: connection_get_type(463) > Connected Network = 2
04-01 22:46:17.383+0900 I/CAPI_NETWORK_CONNECTION( 1420): connection.c: connection_destroy(427) > Destroy handle: 0xb8c10ef0
04-01 22:46:17.383+0900 E/weather-common( 1420): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-01 22:46:17.383+0900 E/weather-widget( 1420): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-01 22:46:17.383+0900 I/CAPI_WIDGET_APPLICATION( 1420): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-01 22:46:17.383+0900 I/CAPI_WIDGET_APPLICATION( 1420): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-01 22:46:17.383+0900 W/AUL     ( 1420): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1420, appid: com.samsung.weather-m-widget, status: fg
04-01 22:46:17.443+0900 I/PHONE   (11099): PhDialerInputFieldControl.cpp: __unregisterListener(601) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.463+0900 I/WAPP    (11099): WView.cpp: __objDelCb(73) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.463+0900 I/PHONE   (11099): PhLogMainListView.cpp: onDestroy(399) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.463+0900 I/PHONE   (11099): PhLogGenlistHelper.cpp: PhLogGenlistHelper(33) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.463+0900 I/WAPP    (11099): WControl.cpp: create(109) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.463+0900 I/PHONE   (11099): PhLogGenlistHelper.cpp: onCreate(44) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.463+0900 I/PHONE   (11099): PhLogGenlistHelper.cpp: __createGenlist(190) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.483+0900 I/PHONE   (11099): PhLogGenlistHelper.cpp: onDestroy(50) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.483+0900 I/PHONE   (11099): PhLogGenlistHelper.cpp: ~PhLogGenlistHelper(38) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.493+0900 I/PHONE   (11099): PhLogListView.cpp: ~PhLogListView(48) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.503+0900 I/WAPP    (11099): WNaviframe.cpp: __objDelCb(82) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.503+0900 I/WAPP    (11099): WNaviframe.cpp: ~WNaviframe(97) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.503+0900 I/WAPP    (11099): WWindow.cpp: __objDelCb(87) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.503+0900 I/WAPP    (11099): WWindow.cpp: ~WWindow(103) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.533+0900 I/MALI    (11099): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=11099   close drm_fd=30 
04-01 22:46:17.603+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 12981 pgid = 12981
04-01 22:46:17.603+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(143) > dead_pid(12981)
04-01 22:46:17.643+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-01 22:46:17.643+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-01 22:46:17.643+0900 E/AUL_PAD ( 1508): launchpad.c: main(698) > error reading sigchld info
04-01 22:46:17.643+0900 I/ESD     (  913): esd_main.c: __esd_app_dead_handler(1773) > pid: 12981
04-01 22:46:17.643+0900 I/Tizen::App( 1247): (243) > App[com.samsung.task-mgr] pid[12981] terminate event is forwarded
04-01 22:46:17.643+0900 I/Tizen::System( 1247): (256) > osp.accessorymanager.service provider is found.
04-01 22:46:17.643+0900 I/Tizen::System( 1247): (196) > Accessory Owner is removed [com.samsung.task-mgr, 12981, ]
04-01 22:46:17.643+0900 I/Tizen::System( 1247): (256) > osp.system.service provider is found.
04-01 22:46:17.643+0900 I/Tizen::App( 1247): (506) > TerminatedApp(com.samsung.task-mgr)
04-01 22:46:17.643+0900 I/Tizen::App( 1247): (512) > Not registered pid(12981)
04-01 22:46:17.643+0900 I/Tizen::System( 1247): (246) > Terminated app [com.samsung.task-mgr]
04-01 22:46:17.643+0900 I/Tizen::Io( 1247): (729) > Entry not found
04-01 22:46:17.643+0900 W/AUL_AMD (  605): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 12981
04-01 22:46:17.643+0900 W/AUL_AMD (  605): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 12981
04-01 22:46:17.653+0900 E/RESOURCED(  685): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1001
04-01 22:46:17.663+0900 I/Tizen::System( 1247): (157) > change brightness system value.
04-01 22:46:17.663+0900 I/Tizen::App( 1247): (782) > Finished invoking application event listener for com.samsung.task-mgr, 12981.
04-01 22:46:17.804+0900 I/PHONE   (11099): ContactsApp.cpp: ~ContactsApp(63) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.804+0900 I/CAPI_APPFW_APPLICATION(11099): app_main.c: ui_app_remove_event_handler(859) > handler list is not initialized
04-01 22:46:17.804+0900 I/WAPP    (11099): WApp.cpp: ~WApp(116) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.804+0900 I/PHONE   (11099): PhLogDbMgr.cpp: ~PhLogDbMgr(78) > [0;32mBEGIN >>>>[0;m
04-01 22:46:17.804+0900 I/PHONE   (11099): PhSimMgr.cpp: ~PhSimMgr(56) > [0;34m>>>HIT<<<[0;m
04-01 22:46:17.804+0900 I/PHONE   (11099): PhSimMgr.cpp: __unsetSimChangeCallback(679) > [0;32mBEGIN >>>>[0;m
04-01 22:46:17.934+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 11099 pgid = 11099
04-01 22:46:17.934+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(143) > dead_pid(11099)
04-01 22:46:17.954+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-01 22:46:17.954+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-01 22:46:17.954+0900 E/AUL_PAD ( 1508): launchpad.c: main(698) > error reading sigchld info
04-01 22:46:17.954+0900 I/ESD     (  913): esd_main.c: __esd_app_dead_handler(1773) > pid: 11099
04-01 22:46:17.954+0900 I/Tizen::App( 1247): (243) > App[com.samsung.contacts] pid[11099] terminate event is forwarded
04-01 22:46:17.954+0900 I/Tizen::System( 1247): (256) > osp.accessorymanager.service provider is found.
04-01 22:46:17.954+0900 I/Tizen::System( 1247): (196) > Accessory Owner is removed [com.samsung.contacts, 11099, ]
04-01 22:46:17.954+0900 I/Tizen::System( 1247): (256) > osp.system.service provider is found.
04-01 22:46:17.954+0900 I/Tizen::App( 1247): (506) > TerminatedApp(com.samsung.contacts)
04-01 22:46:17.954+0900 I/Tizen::App( 1247): (512) > Not registered pid(11099)
04-01 22:46:17.954+0900 I/Tizen::System( 1247): (246) > Terminated app [com.samsung.contacts]
04-01 22:46:17.954+0900 I/Tizen::Io( 1247): (729) > Entry not found
04-01 22:46:17.954+0900 W/AUL_AMD (  605): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 11099
04-01 22:46:17.954+0900 E/RESOURCED(  685): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1002
04-01 22:46:17.964+0900 I/Tizen::System( 1247): (157) > change brightness system value.
04-01 22:46:17.964+0900 I/Tizen::App( 1247): (782) > Finished invoking application event listener for com.samsung.contacts, 11099.
04-01 22:46:19.435+0900 W/AUL_AMD (  605): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-01 22:46:19.435+0900 W/AUL_AMD (  605): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-01 22:46:19.445+0900 W/AUL_AMD (  605): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-01 22:46:19.475+0900 W/AUL_AMD (  605): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-01 22:46:19.475+0900 W/AUL_AMD (  605): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-01 22:46:22.108+0900 W/AUL_AMD (  605): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-01 22:46:22.108+0900 W/AUL_AMD (  605): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-01 22:46:22.168+0900 E/AUL_AMD (  605): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
04-01 22:46:26.262+0900 E/PKGMGR_SERVER(13248): pkgmgr-server.c: main(2414) > package manager server start
04-01 22:46:26.302+0900 E/PKGMGR  (13246): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-01 22:46:26.342+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 22:46:26.342+0900 E/AUL_AMD (  605): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 12901
04-01 22:46:26.352+0900 W/AUL_AMD (  605): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-01 22:46:26.352+0900 E/PKGMGR_SERVER(13248): pkgmgr-server.c: sighandler(417) > child NORMAL exit [13251]
04-01 22:46:27.223+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:27.223+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:27.223+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:27.223+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:27.223+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:46:27.223+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:46:27.223+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-01 22:46:27.223+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:27.223+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:27.223+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:27.223+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:46:27.223+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:46:28.234+0900 E/PKGMGR_SERVER(13248): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-01 22:46:28.234+0900 E/PKGMGR_SERVER(13248): pkgmgr-server.c: main(2471) > package manager server terminated.
04-01 22:46:30.226+0900 E/PKGMGR  (13337): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-01 22:46:30.296+0900 E/PKGMGR_SERVER(13339): pkgmgr-server.c: main(2414) > package manager server start
04-01 22:46:30.346+0900 E/PKGMGR_SERVER(13339): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-01 22:46:30.356+0900 E/PKGMGR_SERVER(13339): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-01 22:46:30.356+0900 E/PKGMGR  (13337): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[133370002]
04-01 22:46:30.516+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-01 22:46:30.516+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-01 22:46:30.516+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:30.516+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:30.516+0900 W/AUL_AMD (  605): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-01 22:46:30.526+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:30.526+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-01 22:46:30.526+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:30.526+0900 I/Tizen::App( 1247): (119) > InstallationInProgress [30]
04-01 22:46:30.526+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-01 22:46:30.646+0900 W/CERT_SVC_VCORE(13342): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-01 22:46:30.706+0900 E/rpm-installer(13342): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-01 22:46:30.706+0900 E/rpm-installer(13342): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-01 22:46:30.766+0900 E/PKGMGR_PARSER(13342): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-01 22:46:30.786+0900 I/PRIVACY-MANAGER-CLIENT(13342): SocketClient.cpp: SocketClient(37) > Client created
04-01 22:46:30.786+0900 I/PRIVACY-MANAGER-CLIENT(13342): SocketClient.cpp: connect(62) > Client connected
04-01 22:46:30.786+0900 I/PRIVACY-MANAGER-SERVER(  937): SocketService.cpp: mainloop(230) > Got incoming connection
04-01 22:46:30.786+0900 I/PRIVACY-MANAGER-CLIENT(13342): SocketClient.cpp: disconnect(72) > Client disconnected
04-01 22:46:30.786+0900 E/PKGMGR_CERT(13342): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-01 22:46:30.796+0900 E/PKGMGR_CERT(13342): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-01 22:46:30.796+0900 E/PKGMGR_CERT(13342): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-01 22:46:30.826+0900 E/rpm-installer(13342): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-01 22:46:30.836+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:30.836+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-01 22:46:30.836+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:30.836+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-01 22:46:30.836+0900 E/ESD     (  913): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-01 22:46:30.846+0900 W/AUL_AMD (  605): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-01 22:46:30.846+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-01 22:46:30.846+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-01 22:46:32.238+0900 E/PKGMGR_SERVER(13339): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-01 22:46:32.528+0900 E/PKGMGR_SERVER(13339): pkgmgr-server.c: sighandler(417) > child NORMAL exit [13342]
04-01 22:46:33.379+0900 E/PKGMGR  (13390): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-01 22:46:33.409+0900 E/PKGMGR_SERVER(13339): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-01 22:46:33.419+0900 E/PKGMGR_INFO(13339): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-01 22:46:33.429+0900 E/rpm-installer(13339): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-01 22:46:33.429+0900 E/PKGMGR_SERVER(13339): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-01 22:46:33.439+0900 E/PKGMGR  (13390): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[133900002]
04-01 22:46:33.559+0900 E/PKGMGR_INSTALLER(13392): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-01 22:46:33.559+0900 E/rpm-installer(13392): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-01 22:46:33.569+0900 E/rpm-installer(13392): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-01 22:46:33.569+0900 E/rpm-installer(13392): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-01 22:46:33.569+0900 E/rpm-installer(13392): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-01 22:46:33.569+0900 E/rpm-installer(13392): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-01 22:46:33.569+0900 E/rpm-installer(13392): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-01 22:46:33.629+0900 W/CERT_SVC_VCORE(13392): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-01 22:46:33.679+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-01 22:46:33.679+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-01 22:46:33.679+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:33.679+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:33.689+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-01 22:46:33.689+0900 I/Tizen::App( 1247): (119) > InstallationInProgress [30]
04-01 22:46:33.689+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-01 22:46:33.689+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:33.689+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:33.849+0900 E/rpm-installer(13392): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-01 22:46:33.849+0900 E/rpm-installer(13392): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-01 22:46:33.849+0900 E/rpm-installer(13392): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-01 22:46:33.849+0900 E/rpm-installer(13392): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-01 22:46:33.849+0900 E/rpm-installer(13392): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-01 22:46:33.849+0900 E/rpm-installer(13392): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-01 22:46:33.859+0900 E/PKGMGR_PARSER(13392): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-01 22:46:33.859+0900 E/PKGMGR_PARSER(13392): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-01 22:46:33.899+0900 I/PRIVACY-MANAGER-CLIENT(13392): SocketClient.cpp: SocketClient(37) > Client created
04-01 22:46:34.109+0900 E/PKGMGR_PARSER(13392): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-01 22:46:34.119+0900 E/PKGMGR_CERT(13392): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-01 22:46:34.129+0900 E/PKGMGR_CERT(13392): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 108
04-01 22:46:34.129+0900 E/PKGMGR_CERT(13392): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 108
04-01 22:46:34.129+0900 E/PKGMGR_CERT(13392): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
04-01 22:46:34.129+0900 E/PKGMGR_CERT(13392): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 3
04-01 22:46:34.129+0900 E/PKGMGR_CERT(13392): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 3
04-01 22:46:34.129+0900 E/PKGMGR_CERT(13392): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
04-01 22:46:34.129+0900 E/PKGMGR_CERT(13392): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-01 22:46:34.139+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-01 22:46:34.139+0900 I/Tizen::App( 1247): (119) > InstallationInProgress [60]
04-01 22:46:34.139+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-01 22:46:34.139+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:34.139+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:34.149+0900 E/rpm-installer(13392): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-01 22:46:34.170+0900 E/rpm-installer(13392): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-01 22:46:34.180+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-01 22:46:34.180+0900 I/Tizen::App( 1247): (119) > InstallationInProgress [100]
04-01 22:46:34.180+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-01 22:46:34.180+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:34.180+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:34.230+0900 E/PKGMGR_SERVER(13339): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-01 22:46:36.071+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-01 22:46:36.071+0900 I/Tizen::App( 1247): (78) > Installation is Completed. [Package = org.example.client]
04-01 22:46:36.071+0900 I/Tizen::App( 1247): (671) > Enter. package(org.example.client), installationResult(0)
04-01 22:46:36.071+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:36.071+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 22:46:36.071+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-01 22:46:36.071+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-01 22:46:36.071+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-01 22:46:36.081+0900 I/Tizen::App( 1247): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-01 22:46:36.091+0900 I/Tizen::App( 1247): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-01 22:46:36.111+0900 I/Tizen::App( 1247): (416) > appName = [client]
04-01 22:46:36.111+0900 I/Tizen::App( 1247): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-01 22:46:36.111+0900 E/PKGMGR_INFO( 1247): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-01 22:46:36.111+0900 I/Tizen::App( 1247): (683) > Application count(1) in this package
04-01 22:46:36.111+0900 I/Tizen::App( 1247): (840) > Enter.
04-01 22:46:36.121+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-01 22:46:36.121+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-01 22:46:36.121+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-01 22:46:36.121+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-01 22:46:36.121+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-01 22:46:36.121+0900 I/Tizen::App( 1247): (703) > Exit.
04-01 22:46:36.121+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-01 22:46:36.121+0900 I/Tizen::App( 1247): (416) > appName = [client]
04-01 22:46:36.121+0900 I/Tizen::App( 1247): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-01 22:46:36.121+0900 I/Tizen::App( 1247): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-01 22:46:36.131+0900 I/Tizen::App( 1247): (131) > Enter
04-01 22:46:36.131+0900 I/Tizen::App( 1247): (137) > org.example.client does not have launch condition
04-01 22:46:36.131+0900 I/Tizen::App( 1247): (883) > Exit.
04-01 22:46:36.131+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-01 22:46:36.131+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-01 22:46:36.131+0900 E/HOME_APPS(  878): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-01 22:46:36.141+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-01 22:46:36.141+0900 W/HOME_APPS(  878): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-01 22:46:36.151+0900 E/PKGMGR_SERVER(13339): pkgmgr-server.c: sighandler(417) > child NORMAL exit [13392]
04-01 22:46:36.161+0900 E/util-view(  878): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-01 22:46:36.191+0900 W/HOME_APPS(  878): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-01 22:46:36.232+0900 E/PKGMGR_SERVER(13339): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-01 22:46:36.232+0900 E/PKGMGR_SERVER(13339): pkgmgr-server.c: main(2471) > package manager server terminated.
04-01 22:46:40.035+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:40.035+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:40.035+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:40.035+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:40.035+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:46:40.035+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:46:40.035+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-01 22:46:40.035+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:40.035+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:40.035+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:46:40.035+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:46:40.035+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:46:40.275+0900 W/AUL     (13448): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-01 22:46:40.275+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 0
04-01 22:46:40.285+0900 I/AUL     (  605): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-01 22:46:40.295+0900 I/AUL     (  605): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-01 22:46:40.295+0900 E/AUL_AMD (  605): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-01 22:46:40.295+0900 W/AUL_AMD (  605): amd_launch.c: _start_app(2508) > caller pid : 13448
04-01 22:46:40.295+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-01 22:46:40.306+0900 E/RESOURCED(  685): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 9
04-01 22:46:40.306+0900 E/RESOURCED(  685): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-01 22:46:40.306+0900 W/AUL_AMD (  605): amd_launch.c: _start_app(3052) > pad pid(-5)
04-01 22:46:40.306+0900 W/AUL_PAD ( 1508): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-01 22:46:40.306+0900 W/AUL_PAD ( 1508): launchpad.c: __send_result_to_caller(267) > Check app launching
04-01 22:46:40.326+0900 I/abc     (12774): abc
04-01 22:46:40.326+0900 I/CAPI_APPFW_APPLICATION(12774): app_main.c: ui_app_main(789) > app_efl_main
04-01 22:46:40.326+0900 I/CAPI_APPFW_APPLICATION(12774): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-01 22:46:40.356+0900 E/TBM     (12774): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-01 22:46:40.406+0900 W/AUL     (  605): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 12774, appid: org.example.client
04-01 22:46:40.406+0900 E/AUL     (  605): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-01 22:46:40.426+0900 W/AUL     (13448): launch.c: app_request_to_launchpad(425) > request cmd(0) result(12774)
04-01 22:46:40.716+0900 W/CRASH_MANAGER(13463): worker.c: worker_job(1199) > 1112774636c69149105440
