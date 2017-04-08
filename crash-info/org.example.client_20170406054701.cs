S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 15497
Date: 2017-04-06 05:47:01+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 15497, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00003c89
r2   = 0x00000006, r3   = 0xb40f04c0
r4   = 0x00000002, r5   = 0xb40f0000
r6   = 0xb67ea09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f18708
r10  = 0xb83912e8, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbe98ac2c
lr   = 0xb66e0f18, pc   = 0xb66dfb84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     74880 KB
Buffers:     65016 KB
Cached:     284680 KB
VmPeak:     133924 KB
VmSize:     133920 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28336 KB
VmRSS:       28336 KB
VmData:      45860 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 15497 TID = 15497
15497 15498 15641 15642 15650 

Maps Information
aee8e000 af68d000 rw-p [stack:15650]
b0f95000 b0fa6000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0fb6000 b0fbb000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13bd000 b13c5000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13d7000 b1bd6000 rw-p [stack:15642]
b1bd6000 b1bd7000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1be7000 b1bfb000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c0f000 b1c10000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c20000 b1c23000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c34000 b1c35000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c45000 b1c47000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c57000 b1c59000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c69000 b1c79000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c89000 b1c95000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1ca7000 b24a6000 rw-p [stack:15641]
b27d7000 b27de000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27f1000 b27f7000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2807000 b2823000 r-xp /opt/usr/apps/org.example.client/bin/client
b297c000 b2a5f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a96000 b2abe000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ad0000 b32cf000 rw-p [stack:15498]
b32cf000 b32d1000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32e1000 b32eb000 r-xp /lib/libnss_files-2.20-2014.11.so
b32fc000 b3305000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3316000 b3327000 r-xp /lib/libnsl-2.20-2014.11.so
b333a000 b3340000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3351000 b3352000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b337a000 b3381000 r-xp /usr/lib/libminizip.so.1.0.0
b3391000 b3396000 r-xp /usr/lib/libstorage.so.0.1
b33a6000 b3405000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b341b000 b342f000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b343f000 b3483000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3493000 b349b000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34ab000 b34db000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34ee000 b35a7000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35bb000 b360e000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b361f000 b363a000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b364a000 b370b000 r-xp /usr/lib/libprotobuf.so.9.0.1
b371e000 b372e000 r-xp /usr/lib/libefl-assist.so.0.1.0
b373e000 b374b000 r-xp /usr/lib/libmdm-common.so.1.0.98
b375c000 b3763000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3773000 b37b4000 r-xp /usr/lib/libmdm.so.1.2.12
b37c4000 b37cc000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37db000 b37eb000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b380c000 b386c000 r-xp /usr/lib/libasound.so.2.0.0
b387e000 b3881000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3891000 b3894000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38a4000 b38a9000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38b9000 b38ba000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38ca000 b38d5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38e9000 b38f0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3900000 b3906000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3916000 b391b000 r-xp /usr/lib/libmmfsession.so.0.0.1
b392b000 b3946000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3956000 b395d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b396d000 b3970000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3981000 b39af000 r-xp /usr/lib/libidn.so.11.5.44
b39bf000 b39d5000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39e6000 b39f0000 r-xp /usr/lib/libcares.so.2.1.0
b3a00000 b3a0a000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a1a000 b3a1c000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a2c000 b3a2d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a3d000 b3a41000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a52000 b3a7a000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a8b000 b3ab4000 r-xp /usr/lib/libturbojpeg.so
b3ad4000 b3ada000 r-xp /usr/lib/libgif.so.4.1.6
b3aea000 b3b30000 r-xp /usr/lib/libcurl.so.4.3.0
b3b41000 b3b62000 r-xp /usr/lib/libexif.so.12.3.3
b3b7d000 b3b92000 r-xp /usr/lib/libtts.so
b3ba3000 b3bab000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bbb000 b3c81000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ca1000 b3d99000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3db8000 b3e86000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e9d000 b3e9f000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eaf000 b3eb5000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ec5000 b3ee8000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ef9000 b3efb000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f0b000 b3f0d000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f1e000 b3f23000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f3a000 b3f3c000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f4c000 b3f53000 r-xp /usr/lib/libsensord-share.so
b3f63000 b3f7b000 r-xp /usr/lib/libsensor.so.1.1.0
b3f8c000 b3f8f000 r-xp /usr/lib/libXv.so.1.0.0
b3f9f000 b3fa4000 r-xp /usr/lib/libutilX.so.1.1.0
b3fb4000 b3fb9000 r-xp /usr/lib/libappcore-common.so.1.1
b3fc9000 b3fd0000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fe3000 b3fe7000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3ff8000 b40d6000 r-xp /usr/lib/libCOREGL.so.4.0
b40f6000 b40f9000 r-xp /usr/lib/libuuid.so.1.3.0
b4109000 b4120000 r-xp /usr/lib/libblkid.so.1.1.0
b4131000 b4133000 r-xp /usr/lib/libXau.so.6.0.0
b4143000 b418a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b419c000 b41a2000 r-xp /usr/lib/libjson-c.so.2.0.1
b41b3000 b41b7000 r-xp /usr/lib/libogg.so.0.7.1
b41c7000 b41e9000 r-xp /usr/lib/libvorbis.so.0.4.3
b41f9000 b42dd000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42f9000 b42fc000 r-xp /usr/lib/libEGL.so.1.4
b430d000 b4313000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4323000 b4325000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4335000 b4342000 r-xp /usr/lib/libGLESv2.so.2.0
b4353000 b43b5000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43ca000 b43e2000 r-xp /usr/lib/libmount.so.1.1.0
b43f4000 b4408000 r-xp /usr/lib/libxcb.so.1.1.0
b4418000 b441f000 r-xp /lib/libcrypt-2.20-2014.11.so
b4457000 b4459000 r-xp /usr/lib/libiri.so
b4469000 b4474000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4485000 b44bb000 r-xp /usr/lib/libpulse.so.0.16.2
b44cc000 b450f000 r-xp /usr/lib/libsndfile.so.1.0.25
b4524000 b4539000 r-xp /lib/libexpat.so.1.5.2
b454b000 b4609000 r-xp /usr/lib/libcairo.so.2.11200.14
b461d000 b4625000 r-xp /usr/lib/libdrm.so.2.4.0
b4635000 b4638000 r-xp /usr/lib/libdri2.so.0.0.0
b4648000 b4696000 r-xp /usr/lib/libssl.so.1.0.0
b46ab000 b46b7000 r-xp /usr/lib/libeeze.so.1.13.0
b46c8000 b46d1000 r-xp /usr/lib/libethumb.so.1.13.0
b46e1000 b46e4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46f4000 b48ab000 r-xp /usr/lib/libcrypto.so.1.0.0
b5696000 b569f000 r-xp /usr/lib/libXi.so.6.1.0
b56af000 b56b1000 r-xp /usr/lib/libXgesture.so.7.0.0
b56c1000 b56c5000 r-xp /usr/lib/libXtst.so.6.1.0
b56d5000 b56db000 r-xp /usr/lib/libXrender.so.1.3.0
b56eb000 b56f1000 r-xp /usr/lib/libXrandr.so.2.2.0
b5701000 b5703000 r-xp /usr/lib/libXinerama.so.1.0.0
b5714000 b5717000 r-xp /usr/lib/libXfixes.so.3.1.0
b5727000 b5732000 r-xp /usr/lib/libXext.so.6.4.0
b5742000 b5744000 r-xp /usr/lib/libXdamage.so.1.1.0
b5754000 b5756000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5766000 b5848000 r-xp /usr/lib/libX11.so.6.3.0
b585c000 b5863000 r-xp /usr/lib/libXcursor.so.1.0.2
b5873000 b588b000 r-xp /usr/lib/libudev.so.1.6.0
b588d000 b5890000 r-xp /lib/libattr.so.1.1.0
b58a0000 b58c0000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58c1000 b58c6000 r-xp /usr/lib/libffi.so.6.0.2
b58d7000 b58ef000 r-xp /lib/libz.so.1.2.8
b58ff000 b5901000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5911000 b59e6000 r-xp /usr/lib/libxml2.so.2.9.2
b59fb000 b5a96000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ab2000 b5ab5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ac5000 b5ade000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aef000 b5b00000 r-xp /lib/libresolv-2.20-2014.11.so
b5b14000 b5b8e000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5ba3000 b5ba5000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bb5000 b5bbc000 r-xp /usr/lib/libembryo.so.1.13.0
b5bcc000 b5bd6000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5be7000 b5bff000 r-xp /usr/lib/libpng12.so.0.50.0
b5c10000 b5c33000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c54000 b5c68000 r-xp /usr/lib/libector.so.1.13.0
b5c79000 b5c91000 r-xp /usr/lib/liblua-5.1.so
b5ca2000 b5cf9000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d0d000 b5d35000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d46000 b5d59000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d6a000 b5da4000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5db5000 b5dc3000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dd3000 b5ddb000 r-xp /usr/lib/libtbm.so.1.0.0
b5deb000 b5df8000 r-xp /usr/lib/libeio.so.1.13.0
b5e08000 b5e0a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e1a000 b5e1f000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e2f000 b5e46000 r-xp /usr/lib/libefreet.so.1.13.0
b5e58000 b5e78000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e88000 b5ea8000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eaa000 b5eb0000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ec0000 b5ed1000 r-xp /usr/lib/libemotion.so.1.13.0
b5ee2000 b5ee9000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ef9000 b5f08000 r-xp /usr/lib/libeo.so.1.13.0
b5f19000 b5f2b000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f3c000 b5f41000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f51000 b5f6a000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f7a000 b5f97000 r-xp /usr/lib/libeet.so.1.13.0
b5fb0000 b5ff8000 r-xp /usr/lib/libeina.so.1.13.0
b6009000 b6019000 r-xp /usr/lib/libefl.so.1.13.0
b602a000 b610f000 r-xp /usr/lib/libicuuc.so.51.1
b612c000 b626c000 r-xp /usr/lib/libicui18n.so.51.1
b6283000 b62bb000 r-xp /usr/lib/libecore_x.so.1.13.0
b62cd000 b62d0000 r-xp /lib/libcap.so.2.21
b62e0000 b6309000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b631a000 b6321000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6333000 b636a000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b637b000 b6466000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6479000 b64f2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6504000 b6509000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6519000 b6523000 r-xp /usr/lib/libvconf.so.0.2.45
b6533000 b6535000 r-xp /usr/lib/libvasum.so.0.3.1
b6545000 b6547000 r-xp /usr/lib/libttrace.so.1.1
b6557000 b655a000 r-xp /usr/lib/libiniparser.so.0
b656a000 b6590000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65a0000 b65a5000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65b6000 b65cd000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65de000 b6649000 r-xp /lib/libm-2.20-2014.11.so
b665a000 b6660000 r-xp /lib/librt-2.20-2014.11.so
b6671000 b667e000 r-xp /usr/lib/libunwind.so.8.0.1
b66b4000 b67d8000 r-xp /lib/libc-2.20-2014.11.so
b67ed000 b6806000 r-xp /lib/libgcc_s-4.9.so.1
b6816000 b68f8000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6909000 b6933000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6944000 b6980000 r-xp /usr/lib/libsystemd.so.0.4.0
b6982000 b6a05000 r-xp /usr/lib/libedje.so.1.13.0
b6a18000 b6a36000 r-xp /usr/lib/libecore.so.1.13.0
b6a56000 b6bdd000 r-xp /usr/lib/libevas.so.1.13.0
b6c12000 b6c26000 r-xp /lib/libpthread-2.20-2014.11.so
b6c3a000 b6e6e000 r-xp /usr/lib/libelementary.so.1.13.0
b6e9d000 b6ea1000 r-xp /usr/lib/libsmack.so.1.0.0
b6eb1000 b6eb8000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ec8000 b6eca000 r-xp /usr/lib/libdlog.so.0.0.0
b6eda000 b6edd000 r-xp /usr/lib/libbundle.so.0.1.22
b6eed000 b6eef000 r-xp /lib/libdl-2.20-2014.11.so
b6f00000 b6f18000 r-xp /usr/lib/libaul.so.0.1.0
b6f2c000 b6f31000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f42000 b6f4f000 r-xp /usr/lib/liblptcp.so
b6f61000 b6f65000 r-xp /usr/lib/libsys-assert.so
b6f76000 b6f96000 r-xp /lib/ld-2.20-2014.11.so
b6fa7000 b6fac000 r-xp /usr/bin/launchpad-loader
b800d000 b83ec000 rw-p [heap]
be96b000 be98c000 rw-p [stack]
be96b000 be98c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15497)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66dfb84) [/lib/libc.so.6] + 0x2bb84
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
> Finished invoking application event listener for com.samsung.task-mgr, 12007.
04-06 05:46:24.506+0900 E/EFL     (15385): edje<15385> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:24.506+0900 E/EFL     (15385): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:24.506+0900 E/EFL     (15385): edje<15385> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:24.506+0900 E/EFL     (15385): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:24.506+0900 E/EFL     (15385): edje<15385> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:24.506+0900 E/EFL     (15385): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:24.957+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223104324
04-06 05:46:25.007+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223104379
04-06 05:46:25.017+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-06 05:46:25.017+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
04-06 05:46:25.017+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 858
04-06 05:46:25.027+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 05:46:25.027+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:46:25.027+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:46:25.027+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:46:25.027+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:46:25.047+0900 I/abc     (15374): abc
04-06 05:46:25.047+0900 I/CAPI_APPFW_APPLICATION(15374): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:46:25.047+0900 I/CAPI_APPFW_APPLICATION(15374): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:46:25.077+0900 E/TBM     (15374): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:46:25.127+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15374, appid: org.example.client
04-06 05:46:25.127+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:46:25.137+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(425) > request cmd(1) result(15374)
04-06 05:46:25.337+0900 D/basicui (15374): successed to load edc file
04-06 05:46:25.377+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:25.377+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:25.407+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:46:25.407+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:25.407+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:25.407+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:25.437+0900 I/MY_LOG  (15374): change
04-06 05:46:25.487+0900 I/APP_CORE(15374): appcore-efl.c: __do_app(514) > [APP 15374] Event: RESET State: CREATED
04-06 05:46:25.487+0900 I/CAPI_APPFW_APPLICATION(15374): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:46:25.497+0900 E/EFL     (15374): edje<15374> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:25.497+0900 E/EFL     (15374): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:25.507+0900 E/EFL     (15374): edje<15374> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:25.507+0900 E/EFL     (15374): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:25.507+0900 E/EFL     (15374): edje<15374> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:25.507+0900 E/EFL     (15374): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:25.517+0900 W/APP_CORE(15374): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
04-06 05:46:25.517+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:46:25.628+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 05:46:25.628+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:46:25.628+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 05:46:25.628+0900 I/APP_CORE(15374): appcore-efl.c: __do_app(514) > [APP 15374] Event: RESUME State: CREATED
04-06 05:46:25.638+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 05:46:25.638+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 05:46:25.638+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 05:46:25.638+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(15374) status(3)
04-06 05:46:25.648+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(15374)
04-06 05:46:25.648+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 15374, appid: org.example.client, status: fg
04-06 05:46:25.648+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:46:25.648+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:46:25.648+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 05:46:25.658+0900 I/APP_CORE(15374): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:46:25.658+0900 I/APP_CORE(15374): appcore-efl.c: __do_app(625) > [APP 15374] Initial Launching, call the resume_cb
04-06 05:46:25.658+0900 I/CAPI_APPFW_APPLICATION(15374): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:46:25.998+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(15374) status(0)
04-06 05:46:26.168+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2374
04-06 05:46:26.178+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 05:46:26.178+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 15374.
04-06 05:46:26.939+0900 I/UXT     (15414): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:46:28.020+0900 E/EFL     (15374): ecore_x<15374> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223107377
04-06 05:46:28.020+0900 I/MY_LOG  (15374): Button pressed
04-06 05:46:28.100+0900 E/EFL     (15374): ecore_x<15374> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223107466
04-06 05:46:28.110+0900 E/VCONF   (15374): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:46:28.110+0900 E/VCONF   (15374): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:46:28.110+0900 E/VCONF   (15374): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:46:28.110+0900 E/VCONF   (15374): vconf.c: vconf_get_bool(2729) > vconf_get_bool(15374) : db/ise/keysound error
04-06 05:46:28.110+0900 E/VCONF   (15374): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:46:28.110+0900 E/VCONF   (15374): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:46:28.160+0900 I/MY_LOG  (15374): Button unpressed
04-06 05:46:28.280+0900 W/CRASH_MANAGER(15286): worker.c: worker_job(1199) > 0615374636c691491425188
04-06 05:46:28.310+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 15374 pgid = 15374
04-06 05:46:28.310+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(15374)
04-06 05:46:28.310+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:28.330+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 05:46:28.330+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:46:28.330+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:46:28.330+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 05:46:28.330+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 05:46:28.370+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:46:28.370+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:46:28.370+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 05:46:28.370+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 15374
04-06 05:46:28.370+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[15374] terminate event is forwarded
04-06 05:46:28.370+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 05:46:28.380+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 15374, ]
04-06 05:46:28.380+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 05:46:28.380+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 05:46:28.380+0900 I/Tizen::App( 1231): (512) > Not registered pid(15374)
04-06 05:46:28.380+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 05:46:28.380+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:28.380+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 15374
04-06 05:46:28.380+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 15374
04-06 05:46:28.380+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2378
04-06 05:46:28.390+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 05:46:28.400+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:28.400+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 15374.
04-06 05:46:28.410+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 05:46:28.410+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:46:28.410+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 05:46:28.420+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:28.420+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 05:46:28.440+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 05:46:28.470+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 05:46:28.470+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:28.480+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:28.480+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 05:46:28.480+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:46:28.490+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 05:46:28.490+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 05:46:28.500+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:46:28.500+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:28.510+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b545c0]
04-06 05:46:28.520+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 05:46:28.520+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b545c0
04-06 05:46:28.530+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 05:46:28.540+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 05:46:28.540+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:46:28.540+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:46:28.540+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 05:46:28.771+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:46:28.781+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:46:28.781+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:46:32.564+0900 E/AUL_AMD (  610): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
04-06 05:46:42.454+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223121818
04-06 05:46:42.544+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223121906
04-06 05:46:42.544+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-06 05:46:42.544+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
04-06 05:46:42.544+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 858
04-06 05:46:42.554+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 05:46:42.554+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:46:42.554+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:46:42.554+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:46:42.554+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:46:42.564+0900 I/abc     (15414): abc
04-06 05:46:42.574+0900 I/CAPI_APPFW_APPLICATION(15414): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:46:42.574+0900 I/CAPI_APPFW_APPLICATION(15414): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:46:42.594+0900 E/TBM     (15414): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:46:42.654+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15414, appid: org.example.client
04-06 05:46:42.654+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:46:42.654+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(425) > request cmd(1) result(15414)
04-06 05:46:42.864+0900 D/basicui (15414): successed to load edc file
04-06 05:46:42.904+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:42.904+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:42.914+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:46:42.914+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:42.924+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:42.934+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:42.954+0900 I/MY_LOG  (15414): change
04-06 05:46:43.005+0900 I/APP_CORE(15414): appcore-efl.c: __do_app(514) > [APP 15414] Event: RESET State: CREATED
04-06 05:46:43.005+0900 I/CAPI_APPFW_APPLICATION(15414): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:46:43.015+0900 E/EFL     (15414): edje<15414> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:43.015+0900 E/EFL     (15414): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:43.015+0900 E/EFL     (15414): edje<15414> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:43.015+0900 E/EFL     (15414): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:43.025+0900 E/EFL     (15414): edje<15414> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:43.025+0900 E/EFL     (15414): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:43.025+0900 W/APP_CORE(15414): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-06 05:46:43.025+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:46:43.135+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 05:46:43.135+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:46:43.145+0900 I/APP_CORE(15414): appcore-efl.c: __do_app(514) > [APP 15414] Event: RESUME State: CREATED
04-06 05:46:43.145+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 05:46:43.145+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 05:46:43.145+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 05:46:43.145+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 05:46:43.145+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(15414) status(3)
04-06 05:46:43.145+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(15414)
04-06 05:46:43.145+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 15414, appid: org.example.client, status: fg
04-06 05:46:43.155+0900 I/APP_CORE(15414): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:46:43.155+0900 I/APP_CORE(15414): appcore-efl.c: __do_app(625) > [APP 15414] Initial Launching, call the resume_cb
04-06 05:46:43.155+0900 I/CAPI_APPFW_APPLICATION(15414): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:46:43.165+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:46:43.165+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:46:43.165+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 05:46:43.495+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(15414) status(0)
04-06 05:46:43.725+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 05:46:43.725+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 15414.
04-06 05:46:43.725+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2379
04-06 05:46:44.476+0900 I/UXT     (15497): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:46:45.607+0900 E/EFL     (15414): ecore_x<15414> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223124976
04-06 05:46:45.617+0900 I/MY_LOG  (15414): Button pressed
04-06 05:46:45.697+0900 E/EFL     (15414): ecore_x<15414> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223125064
04-06 05:46:45.697+0900 E/VCONF   (15414): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:46:45.697+0900 E/VCONF   (15414): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:46:45.697+0900 E/VCONF   (15414): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:46:45.697+0900 E/VCONF   (15414): vconf.c: vconf_get_bool(2729) > vconf_get_bool(15414) : db/ise/keysound error
04-06 05:46:45.707+0900 E/VCONF   (15414): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:46:45.707+0900 E/VCONF   (15414): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:46:45.747+0900 I/MY_LOG  (15414): Button unpressed
04-06 05:46:45.887+0900 W/CRASH_MANAGER(15286): worker.c: worker_job(1199) > 0615414636c691491425205
04-06 05:46:45.907+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 15414 pgid = 15414
04-06 05:46:45.907+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(15414)
04-06 05:46:45.917+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:45.937+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 05:46:45.937+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:46:45.937+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:46:45.937+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 05:46:45.937+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 05:46:45.977+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:46:45.977+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:46:45.977+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 05:46:45.987+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 15414
04-06 05:46:45.987+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[15414] terminate event is forwarded
04-06 05:46:45.987+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 05:46:45.987+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 15414, ]
04-06 05:46:45.987+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 05:46:45.987+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 05:46:45.987+0900 I/Tizen::App( 1231): (512) > Not registered pid(15414)
04-06 05:46:45.987+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 05:46:45.987+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:45.987+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 15414
04-06 05:46:45.987+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 15414
04-06 05:46:45.987+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2383
04-06 05:46:45.997+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 05:46:45.997+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:45.997+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 15414.
04-06 05:46:46.007+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 05:46:46.007+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:46:46.007+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 05:46:46.007+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:46.027+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 05:46:46.047+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 05:46:46.047+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:46.058+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 05:46:46.068+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:46.068+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 05:46:46.068+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:46:46.078+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 05:46:46.078+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:46:46.078+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:46.088+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 05:46:46.108+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7a912a8]
04-06 05:46:46.108+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 05:46:46.108+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7a912a8
04-06 05:46:46.118+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 05:46:46.128+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 05:46:46.128+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:46:46.128+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:46:46.128+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 05:46:54.986+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_handler_idle(1754) > Lock the display not to enter LCD OFF
04-06 05:46:54.996+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __display_lock_state(2235) > Lock LCD OFF is successfully done
04-06 05:46:54.996+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_expired(1526) > zone: /
04-06 05:46:54.996+0900 W/AUL     (  659): app_signal.c: aul_update_freezer_status(354) > send_update_freezer_status, pid: 558, type: wakeup
04-06 05:46:55.006+0900 E/RESOURCED(  664): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
04-06 05:46:55.006+0900 E/RESOURCED(  664): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
04-06 05:46:55.006+0900 E/RESOURCED(  664): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
04-06 05:46:55.006+0900 E/RESOURCED(  664): freezer-process.c: freezer_process_pid_set(146) > Cant find process info for 558
04-06 05:46:55.006+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(385017234) zone(/)
04-06 05:46:55.006+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-06 05:46:55.006+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 5-4-2017, 21:20:23 (UTC).
04-06 05:46:55.006+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-06 05:46:55.006+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_handler_idle(1780) > Unlock the display from LCD OFF
04-06 05:46:55.016+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __display_unlock_state(2278) > Unlock LCD OFF is successfully done
04-06 05:46:55.016+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-06 05:46:55.016+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/558/status successfully
04-06 05:46:55.016+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 0
04-06 05:46:55.016+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:55.026+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 05:46:55.036+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 05:46:55.046+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:55.046+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 05:46:55.056+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 05:46:55.056+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 38
04-06 05:46:55.056+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/sbin/connmand
04-06 05:46:55.056+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/sbin/connmand
04-06 05:46:55.056+0900 E/ALARM_MANAGER(  659): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1491427015, Thu Apr  6 06:16:55 2017
04-06 05:46:55.056+0900 E/ALARM_MANAGER(  659): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 749141759, next duetime: 1491427015
04-06 05:46:55.056+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(749141759)
04-06 05:46:55.056+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1491427223), due_time(1491427015)
04-06 05:46:55.056+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-06 05:46:55.056+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 5-4-2017, 21:16:55 (UTC).
04-06 05:46:55.056+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-06 05:46:55.066+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-06 05:46:55.066+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/558/status successfully
04-06 05:46:55.066+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 0
04-06 05:46:55.066+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(749141759) zone(/)
04-06 05:46:55.066+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-06 05:46:55.066+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 5-4-2017, 21:20:23 (UTC).
04-06 05:46:55.076+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-06 05:46:55.076+0900 E/ALARM_MANAGER(  659): alarm-manager.c: alarm_manager_alarm_delete(2954) > alarm_id[749141759] is removed.
04-06 05:46:55.076+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-06 05:46:55.076+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/558/status successfully
04-06 05:46:55.076+0900 W/ALARM_MANAGER(  659): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 0
04-06 05:46:55.076+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:55.086+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 05:46:55.096+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 05:46:55.096+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:55.106+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 05:46:55.116+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-06 05:46:55.116+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 38
04-06 05:46:55.116+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/sbin/connmand
04-06 05:46:55.116+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/sbin/connmand
04-06 05:46:55.116+0900 E/ALARM_MANAGER(  659): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1491428815, Thu Apr  6 06:46:55 2017
04-06 05:46:55.116+0900 E/ALARM_MANAGER(  659): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 749141759, next duetime: 1491428815
04-06 05:46:55.116+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(749141759)
04-06 05:46:55.116+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1491427223), due_time(1491428815)
04-06 05:46:55.116+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-06 05:46:55.116+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 5-4-2017, 21:20:23 (UTC).
04-06 05:46:55.116+0900 E/ALARM_MANAGER(  659): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-06 05:46:56.287+0900 E/PKGMGR_SERVER(15582): pkgmgr-server.c: main(2414) > package manager server start
04-06 05:46:56.338+0900 E/PKGMGR  (15580): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-06 05:46:56.378+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 05:46:56.388+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-06 05:46:56.398+0900 E/PKGMGR_SERVER(15582): pkgmgr-server.c: sighandler(417) > child NORMAL exit [15585]
04-06 05:46:58.640+0900 E/PKGMGR_SERVER(15582): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 05:46:58.640+0900 E/PKGMGR_SERVER(15582): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 05:46:58.800+0900 W/AUL     (15634): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 05:46:58.800+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 05:46:58.810+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 05:46:58.810+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 05:46:58.810+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:46:58.810+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 15634
04-06 05:46:58.810+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:46:58.820+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 05:46:58.820+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:46:58.820+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:46:58.830+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:46:58.830+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:46:58.840+0900 I/abc     (15497): abc
04-06 05:46:58.840+0900 I/CAPI_APPFW_APPLICATION(15497): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:46:58.840+0900 I/CAPI_APPFW_APPLICATION(15497): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:46:58.870+0900 E/TBM     (15497): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:46:58.930+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15497, appid: org.example.client
04-06 05:46:58.930+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:46:58.930+0900 W/AUL     (15634): launch.c: app_request_to_launchpad(425) > request cmd(0) result(15497)
04-06 05:46:59.130+0900 D/basicui (15497): successed to load edc file
04-06 05:46:59.170+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:59.170+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:59.190+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:46:59.190+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:59.190+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:59.200+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:59.230+0900 I/MY_LOG  (15497): change
04-06 05:46:59.270+0900 I/APP_CORE(15497): appcore-efl.c: __do_app(514) > [APP 15497] Event: RESET State: CREATED
04-06 05:46:59.270+0900 I/CAPI_APPFW_APPLICATION(15497): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:46:59.280+0900 E/EFL     (15497): edje<15497> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:59.280+0900 E/EFL     (15497): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:59.290+0900 E/EFL     (15497): edje<15497> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:59.290+0900 E/EFL     (15497): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:59.290+0900 E/EFL     (15497): edje<15497> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:59.290+0900 E/EFL     (15497): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:59.300+0900 W/APP_CORE(15497): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
04-06 05:46:59.300+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:46:59.411+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 05:46:59.411+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:46:59.411+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 05:46:59.411+0900 I/APP_CORE(15497): appcore-efl.c: __do_app(514) > [APP 15497] Event: RESUME State: CREATED
04-06 05:46:59.411+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 05:46:59.411+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 05:46:59.411+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 05:46:59.421+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(15497) status(3)
04-06 05:46:59.421+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:46:59.421+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:46:59.421+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(15497)
04-06 05:46:59.421+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 15497, appid: org.example.client, status: fg
04-06 05:46:59.431+0900 I/APP_CORE(15497): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:46:59.431+0900 I/APP_CORE(15497): appcore-efl.c: __do_app(625) > [APP 15497] Initial Launching, call the resume_cb
04-06 05:46:59.431+0900 I/CAPI_APPFW_APPLICATION(15497): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:46:59.431+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:46:59.431+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:46:59.431+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 05:46:59.781+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(15497) status(0)
04-06 05:46:59.991+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2387
04-06 05:47:00.001+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 05:47:00.001+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 15497.
04-06 05:47:00.401+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 05:47:00.401+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 5:47
04-06 05:47:00.401+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 5:47"
04-06 05:47:00.401+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 5:47"
04-06 05:47:00.401+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 05:47:00.401+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145544193 Time: <font_size=31> </font_size> <font_size=31> 오전 5:47</font_size></font>"
04-06 05:47:00.512+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:47:00.512+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:47:00.512+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:47:00.512+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:47:00.512+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:47:00.512+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:47:00.512+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 05:47:00.512+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:47:00.512+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:47:00.512+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:47:00.522+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:47:00.522+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:47:00.762+0900 I/UXT     (15647): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:47:01.623+0900 E/EFL     (15497): ecore_x<15497> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223140980
04-06 05:47:01.623+0900 I/MY_LOG  (15497): Button pressed
04-06 05:47:01.713+0900 E/EFL     (15497): ecore_x<15497> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223141069
04-06 05:47:01.713+0900 E/VCONF   (15497): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:47:01.713+0900 E/VCONF   (15497): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:47:01.713+0900 E/VCONF   (15497): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:47:01.713+0900 E/VCONF   (15497): vconf.c: vconf_get_bool(2729) > vconf_get_bool(15497) : db/ise/keysound error
04-06 05:47:01.713+0900 E/VCONF   (15497): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:47:01.713+0900 E/VCONF   (15497): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:47:01.753+0900 I/MY_LOG  (15497): Button unpressed
04-06 05:47:01.883+0900 W/CRASH_MANAGER(15286): worker.c: worker_job(1199) > 0615497636c69149142522
