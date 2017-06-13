S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 26920
Date: 2017-06-03 12:18:37+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 26920, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00006928
r2   = 0x00000006, r3   = 0xb40f34c0
r4   = 0x00000002, r5   = 0xb40f3000
r6   = 0xb67ed09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f1b708
r10  = 0xb82fc558, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbec46e34
lr   = 0xb66e3f18, pc   = 0xb66e2b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     39396 KB
Buffers:     83464 KB
Cached:     266280 KB
VmPeak:     133056 KB
VmSize:     131344 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31032 KB
VmRSS:       27552 KB
VmData:      45340 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35864 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 26920 TID = 26920
26920 26921 27302 27303 27308 

Maps Information
afd03000 b0502000 rw-p [stack:27308]
b12c0000 b12d1000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b12e1000 b12e6000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13ab000 b13b3000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13c5000 b1bc4000 rw-p [stack:27303]
b1bc4000 b1bc5000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bd5000 b1be9000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bfd000 b1bfe000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c0e000 b1c11000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c22000 b1c23000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c33000 b1c35000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c45000 b1c47000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c57000 b1c67000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c77000 b1c83000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c95000 b2494000 rw-p [stack:27302]
b27c5000 b27cc000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27df000 b27e5000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27f5000 b2826000 r-xp /opt/usr/apps/org.example.client/bin/client
b297f000 b2a62000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a99000 b2ac1000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ad3000 b32d2000 rw-p [stack:26921]
b32d2000 b32d4000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32e4000 b32ee000 r-xp /lib/libnss_files-2.20-2014.11.so
b32ff000 b3308000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3319000 b332a000 r-xp /lib/libnsl-2.20-2014.11.so
b333d000 b3343000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3354000 b3355000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b337d000 b3384000 r-xp /usr/lib/libminizip.so.1.0.0
b3394000 b3399000 r-xp /usr/lib/libstorage.so.0.1
b33a9000 b3408000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b341e000 b3432000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3442000 b3486000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3496000 b349e000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34ae000 b34de000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34f1000 b35aa000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35be000 b3611000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3622000 b363d000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b364d000 b370e000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3721000 b3731000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3741000 b374e000 r-xp /usr/lib/libmdm-common.so.1.0.98
b375f000 b3766000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3776000 b37b7000 r-xp /usr/lib/libmdm.so.1.2.12
b37c7000 b37cf000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37de000 b37ee000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b380f000 b386f000 r-xp /usr/lib/libasound.so.2.0.0
b3881000 b3884000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3894000 b3897000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38a7000 b38ac000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38bc000 b38bd000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38cd000 b38d8000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38ec000 b38f3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3903000 b3909000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3919000 b391e000 r-xp /usr/lib/libmmfsession.so.0.0.1
b392e000 b3949000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3959000 b3960000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3970000 b3973000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3984000 b39b2000 r-xp /usr/lib/libidn.so.11.5.44
b39c2000 b39d8000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39e9000 b39f3000 r-xp /usr/lib/libcares.so.2.1.0
b3a03000 b3a0d000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a1d000 b3a1f000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a2f000 b3a30000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a40000 b3a44000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a55000 b3a7d000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a8e000 b3ab7000 r-xp /usr/lib/libturbojpeg.so
b3ad7000 b3add000 r-xp /usr/lib/libgif.so.4.1.6
b3aed000 b3b33000 r-xp /usr/lib/libcurl.so.4.3.0
b3b44000 b3b65000 r-xp /usr/lib/libexif.so.12.3.3
b3b80000 b3b95000 r-xp /usr/lib/libtts.so
b3ba6000 b3bae000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bbe000 b3c84000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ca4000 b3d9c000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dbb000 b3e89000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ea0000 b3ea2000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eb2000 b3eb8000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ec8000 b3eeb000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3efc000 b3efe000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f0e000 b3f10000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f21000 b3f26000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f3d000 b3f3f000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f4f000 b3f56000 r-xp /usr/lib/libsensord-share.so
b3f66000 b3f7e000 r-xp /usr/lib/libsensor.so.1.1.0
b3f8f000 b3f92000 r-xp /usr/lib/libXv.so.1.0.0
b3fa2000 b3fa7000 r-xp /usr/lib/libutilX.so.1.1.0
b3fb7000 b3fbc000 r-xp /usr/lib/libappcore-common.so.1.1
b3fcc000 b3fd3000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fe6000 b3fea000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3ffb000 b40d9000 r-xp /usr/lib/libCOREGL.so.4.0
b40f9000 b40fc000 r-xp /usr/lib/libuuid.so.1.3.0
b410c000 b4123000 r-xp /usr/lib/libblkid.so.1.1.0
b4134000 b4136000 r-xp /usr/lib/libXau.so.6.0.0
b4146000 b418d000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b419f000 b41a5000 r-xp /usr/lib/libjson-c.so.2.0.1
b41b6000 b41ba000 r-xp /usr/lib/libogg.so.0.7.1
b41ca000 b41ec000 r-xp /usr/lib/libvorbis.so.0.4.3
b41fc000 b42e0000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42fc000 b42ff000 r-xp /usr/lib/libEGL.so.1.4
b4310000 b4316000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4326000 b4328000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4338000 b4345000 r-xp /usr/lib/libGLESv2.so.2.0
b4356000 b43b8000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43cd000 b43e5000 r-xp /usr/lib/libmount.so.1.1.0
b43f7000 b440b000 r-xp /usr/lib/libxcb.so.1.1.0
b441b000 b4422000 r-xp /lib/libcrypt-2.20-2014.11.so
b445a000 b445c000 r-xp /usr/lib/libiri.so
b446c000 b4477000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4488000 b44be000 r-xp /usr/lib/libpulse.so.0.16.2
b44cf000 b4512000 r-xp /usr/lib/libsndfile.so.1.0.25
b4527000 b453c000 r-xp /lib/libexpat.so.1.5.2
b454e000 b460c000 r-xp /usr/lib/libcairo.so.2.11200.14
b4620000 b4628000 r-xp /usr/lib/libdrm.so.2.4.0
b4638000 b463b000 r-xp /usr/lib/libdri2.so.0.0.0
b464b000 b4699000 r-xp /usr/lib/libssl.so.1.0.0
b46ae000 b46ba000 r-xp /usr/lib/libeeze.so.1.13.0
b46cb000 b46d4000 r-xp /usr/lib/libethumb.so.1.13.0
b46e4000 b46e7000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46f7000 b48ae000 r-xp /usr/lib/libcrypto.so.1.0.0
b5699000 b56a2000 r-xp /usr/lib/libXi.so.6.1.0
b56b2000 b56b4000 r-xp /usr/lib/libXgesture.so.7.0.0
b56c4000 b56c8000 r-xp /usr/lib/libXtst.so.6.1.0
b56d8000 b56de000 r-xp /usr/lib/libXrender.so.1.3.0
b56ee000 b56f4000 r-xp /usr/lib/libXrandr.so.2.2.0
b5704000 b5706000 r-xp /usr/lib/libXinerama.so.1.0.0
b5717000 b571a000 r-xp /usr/lib/libXfixes.so.3.1.0
b572a000 b5735000 r-xp /usr/lib/libXext.so.6.4.0
b5745000 b5747000 r-xp /usr/lib/libXdamage.so.1.1.0
b5757000 b5759000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5769000 b584b000 r-xp /usr/lib/libX11.so.6.3.0
b585f000 b5866000 r-xp /usr/lib/libXcursor.so.1.0.2
b5876000 b588e000 r-xp /usr/lib/libudev.so.1.6.0
b5890000 b5893000 r-xp /lib/libattr.so.1.1.0
b58a3000 b58c3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58c4000 b58c9000 r-xp /usr/lib/libffi.so.6.0.2
b58da000 b58f2000 r-xp /lib/libz.so.1.2.8
b5902000 b5904000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5914000 b59e9000 r-xp /usr/lib/libxml2.so.2.9.2
b59fe000 b5a99000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ab5000 b5ab8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ac8000 b5ae1000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5af2000 b5b03000 r-xp /lib/libresolv-2.20-2014.11.so
b5b17000 b5b91000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5ba6000 b5ba8000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bb8000 b5bbf000 r-xp /usr/lib/libembryo.so.1.13.0
b5bcf000 b5bd9000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bea000 b5c02000 r-xp /usr/lib/libpng12.so.0.50.0
b5c13000 b5c36000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c57000 b5c6b000 r-xp /usr/lib/libector.so.1.13.0
b5c7c000 b5c94000 r-xp /usr/lib/liblua-5.1.so
b5ca5000 b5cfc000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d10000 b5d38000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d49000 b5d5c000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d6d000 b5da7000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5db8000 b5dc6000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dd6000 b5dde000 r-xp /usr/lib/libtbm.so.1.0.0
b5dee000 b5dfb000 r-xp /usr/lib/libeio.so.1.13.0
b5e0b000 b5e0d000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e1d000 b5e22000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e32000 b5e49000 r-xp /usr/lib/libefreet.so.1.13.0
b5e5b000 b5e7b000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e8b000 b5eab000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ead000 b5eb3000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ec3000 b5ed4000 r-xp /usr/lib/libemotion.so.1.13.0
b5ee5000 b5eec000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5efc000 b5f0b000 r-xp /usr/lib/libeo.so.1.13.0
b5f1c000 b5f2e000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f3f000 b5f44000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f54000 b5f6d000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f7d000 b5f9a000 r-xp /usr/lib/libeet.so.1.13.0
b5fb3000 b5ffb000 r-xp /usr/lib/libeina.so.1.13.0
b600c000 b601c000 r-xp /usr/lib/libefl.so.1.13.0
b602d000 b6112000 r-xp /usr/lib/libicuuc.so.51.1
b612f000 b626f000 r-xp /usr/lib/libicui18n.so.51.1
b6286000 b62be000 r-xp /usr/lib/libecore_x.so.1.13.0
b62d0000 b62d3000 r-xp /lib/libcap.so.2.21
b62e3000 b630c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b631d000 b6324000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6336000 b636d000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b637e000 b6469000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b647c000 b64f5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6507000 b650c000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b651c000 b6526000 r-xp /usr/lib/libvconf.so.0.2.45
b6536000 b6538000 r-xp /usr/lib/libvasum.so.0.3.1
b6548000 b654a000 r-xp /usr/lib/libttrace.so.1.1
b655a000 b655d000 r-xp /usr/lib/libiniparser.so.0
b656d000 b6593000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65a3000 b65a8000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65b9000 b65d0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65e1000 b664c000 r-xp /lib/libm-2.20-2014.11.so
b665d000 b6663000 r-xp /lib/librt-2.20-2014.11.so
b6674000 b6681000 r-xp /usr/lib/libunwind.so.8.0.1
b66b7000 b67db000 r-xp /lib/libc-2.20-2014.11.so
b67f0000 b6809000 r-xp /lib/libgcc_s-4.9.so.1
b6819000 b68fb000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b690c000 b6936000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6947000 b6983000 r-xp /usr/lib/libsystemd.so.0.4.0
b6985000 b6a08000 r-xp /usr/lib/libedje.so.1.13.0
b6a1b000 b6a39000 r-xp /usr/lib/libecore.so.1.13.0
b6a59000 b6be0000 r-xp /usr/lib/libevas.so.1.13.0
b6c15000 b6c29000 r-xp /lib/libpthread-2.20-2014.11.so
b6c3d000 b6e71000 r-xp /usr/lib/libelementary.so.1.13.0
b6ea0000 b6ea4000 r-xp /usr/lib/libsmack.so.1.0.0
b6eb4000 b6ebb000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ecb000 b6ecd000 r-xp /usr/lib/libdlog.so.0.0.0
b6edd000 b6ee0000 r-xp /usr/lib/libbundle.so.0.1.22
b6ef0000 b6ef2000 r-xp /lib/libdl-2.20-2014.11.so
b6f03000 b6f1b000 r-xp /usr/lib/libaul.so.0.1.0
b6f2f000 b6f34000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f45000 b6f52000 r-xp /usr/lib/liblptcp.so
b6f64000 b6f68000 r-xp /usr/lib/libsys-assert.so
b6f79000 b6f99000 r-xp /lib/ld-2.20-2014.11.so
b6faa000 b6faf000 r-xp /usr/bin/launchpad-loader
b7f96000 b8329000 rw-p [heap]
bec27000 bec48000 rw-p [stack]
b7f96000 b8329000 rw-p [heap]
bec27000 bec48000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26920)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66e2b84) [/lib/libc.so.6] + 0x2bb84
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
6-03 12:18:26.354+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
06-03 12:18:26.364+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-03 12:18:26.364+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:18:26.364+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-03 12:18:26.364+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-03 12:18:26.374+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-03 12:18:26.374+0900 W/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-03 12:18:26.384+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-03 12:18:26.384+0900 I/ISE_MULTI(  837): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-03 12:18:26.494+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:26.504+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:26.504+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.504+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:26.504+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.504+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.504+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.504+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.504+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.504+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.504+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.504+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.504+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:26.595+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(3)
06-03 12:18:26.625+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-03 12:18:26.625+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:26.635+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:26.635+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.635+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:26.635+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.635+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.635+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.635+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.635+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.635+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.635+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.635+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.635+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:26.655+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:26.655+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:26.665+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.665+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:26.665+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.665+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.665+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.665+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.665+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.665+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.665+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.665+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:26.665+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:26.685+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
06-03 12:18:26.685+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(26920) status(0)
06-03 12:18:26.685+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
06-03 12:18:27.015+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-03 12:18:27.015+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 26920.
06-03 12:18:27.015+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2979
06-03 12:18:27.776+0900 I/UXT     (27304): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 12:18:28.236+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970983013
06-03 12:18:28.236+0900 I/MY_LOG  (26920): Button pressed
06-03 12:18:28.386+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970983167
06-03 12:18:28.396+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-03 12:18:28.406+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
06-03 12:18:28.436+0900 E/VCONF   (26920): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-03 12:18:28.436+0900 E/VCONF   (26920): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-03 12:18:28.436+0900 E/VCONF   (26920): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-03 12:18:28.436+0900 E/VCONF   (26920): vconf.c: vconf_get_bool(2729) > vconf_get_bool(26920) : db/ise/keysound error
06-03 12:18:28.436+0900 E/VCONF   (26920): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-03 12:18:28.436+0900 E/VCONF   (26920): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-03 12:18:28.496+0900 I/MY_LOG  (26920): Button unpressed
06-03 12:18:28.506+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x7c00002 FAILED!
06-03 12:18:28.587+0900 D/basicui (26920): successed to load edc file
06-03 12:18:28.617+0900 I/MY_LOG  (26920): change
06-03 12:18:28.637+0900 I/MY_LOG  (26920): change
06-03 12:18:28.637+0900 I/MY_LOG  (26920): change
06-03 12:18:28.657+0900 I/MY_LOG  (26920): change
06-03 12:18:28.667+0900 I/MY_LOG  (26920): change
06-03 12:18:29.037+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x7c00002 FAILED!
06-03 12:18:29.047+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x7c00002 FAILED!
06-03 12:18:29.047+0900 I/ISE_MULTI(  837): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:true] mode=1[0m
06-03 12:18:29.057+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-03 12:18:29.057+0900 W/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-03 12:18:29.067+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-03 12:18:29.067+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:18:29.067+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
06-03 12:18:29.067+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-03 12:18:29.067+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:18:29.067+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-03 12:18:29.077+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-03 12:18:29.087+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-03 12:18:29.087+0900 W/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-03 12:18:29.107+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:29.117+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-03 12:18:29.117+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:29.117+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.117+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:29.117+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.117+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.117+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.117+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.117+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.117+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.117+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.117+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.117+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:29.127+0900 E/ISE_MULTI(  837): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 577  rect->height : 577[0m
06-03 12:18:29.157+0900 I/ISE_MULTI(  837): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-03 12:18:29.227+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:29.237+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:29.237+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.237+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:29.237+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.237+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.237+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.237+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.237+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.237+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.237+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.237+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.237+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:29.247+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-03 12:18:29.247+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:29.247+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:29.257+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.257+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:29.257+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.257+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.257+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.257+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.257+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.257+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.257+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.257+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:29.257+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:29.337+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(3)
06-03 12:18:29.387+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
06-03 12:18:29.387+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
06-03 12:18:30.038+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970984813
06-03 12:18:30.038+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970984813
06-03 12:18:30.178+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970984934
06-03 12:18:30.178+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[45]  Y[224] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:30.178+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:30.178+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:30.188+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:30.188+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:30.188+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:30.188+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:30.198+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:18:30.228+0900 I/ISE_MULTI(  837): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:false] mode=0[0m
06-03 12:18:30.238+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:30.338+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970985112
06-03 12:18:30.338+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970985112
06-03 12:18:30.428+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
06-03 12:18:30.438+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:30.448+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
06-03 12:18:30.448+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
06-03 12:18:30.448+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
06-03 12:18:30.458+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:30.458+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:30.458+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.458+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:30.458+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.458+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.458+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.458+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.458+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.458+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.458+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.458+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.458+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:30.478+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970985245
06-03 12:18:30.478+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[117]  Y[245] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:30.478+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:30.478+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:30.488+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:30.488+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:30.639+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970985411
06-03 12:18:30.639+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970985411
06-03 12:18:30.739+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
06-03 12:18:30.739+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:30.749+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
06-03 12:18:30.749+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
06-03 12:18:30.749+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
06-03 12:18:30.749+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:30.759+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:30.759+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.759+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:30.759+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.759+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.759+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.759+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.759+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.759+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.759+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.759+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:30.759+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:30.789+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970985555
06-03 12:18:30.789+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[191]  Y[257] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:30.789+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:30.789+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:30.799+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:30.799+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:30.899+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970985677
06-03 12:18:30.899+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970985677
06-03 12:18:31.009+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:31.029+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970985799
06-03 12:18:31.029+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[261]  Y[243] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:31.029+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:31.029+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:31.029+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:31.029+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:31.279+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
06-03 12:18:31.289+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
06-03 12:18:31.289+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
06-03 12:18:31.289+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
06-03 12:18:31.289+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:31.299+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:31.299+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:31.299+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:31.299+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:31.299+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:31.299+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:31.299+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:31.299+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:31.299+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:31.299+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:31.299+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:31.299+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:31.329+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-03 12:18:31.499+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970986274
06-03 12:18:31.609+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970986384
06-03 12:18:31.609+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-03 12:18:31.629+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
06-03 12:18:31.670+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x7c00002 FAILED!
06-03 12:18:31.680+0900 I/ISE_MULTI(  837): xt9-setting.cpp: xt9_change_onoff(165) > [0;36mPrediction OFF[0m
06-03 12:18:31.710+0900 I/MY_LOG  (26920): change
06-03 12:18:31.730+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-03 12:18:31.730+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-03 12:18:31.730+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:18:31.730+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-03 12:18:31.730+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-03 12:18:31.770+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-03 12:18:31.770+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_hide(927) > [0;33mHide[0m
06-03 12:18:31.770+0900 E/ISE_MULTI(  837): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 577  rect->height : 505[0m
06-03 12:18:31.770+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
06-03 12:18:31.830+0900 I/ISE_MULTI(  837): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-03 12:18:31.910+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-03 12:18:32.460+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970987236
06-03 12:18:32.470+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970987236
06-03 12:18:32.560+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970987312
06-03 12:18:32.560+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[42]  Y[175] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:32.560+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:32.560+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:32.560+0900 I/MY_LOG  (26920): change
06-03 12:18:32.570+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=1[0m
06-03 12:18:32.570+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:32.570+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:32.590+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:32.801+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970987576
06-03 12:18:32.811+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970987576
06-03 12:18:32.951+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970987708
06-03 12:18:32.951+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[115]  Y[170] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:32.961+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:32.961+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:32.961+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=2[0m
06-03 12:18:32.961+0900 I/MY_LOG  (26920): change
06-03 12:18:32.961+0900 I/MY_LOG  (26920): change
06-03 12:18:32.971+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:32.971+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:32.981+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:33.111+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970987886
06-03 12:18:33.111+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970987886
06-03 12:18:33.221+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:33.231+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970988007
06-03 12:18:33.231+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[200]  Y[171] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:33.241+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:33.241+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:33.241+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=3[0m
06-03 12:18:33.241+0900 I/MY_LOG  (26920): change
06-03 12:18:33.241+0900 I/MY_LOG  (26920): change
06-03 12:18:33.241+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:33.241+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:33.381+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970988151
06-03 12:18:33.381+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970988151
06-03 12:18:33.471+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:33.491+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970988251
06-03 12:18:33.491+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[264]  Y[173] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:33.491+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:33.491+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:33.491+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=4[0m
06-03 12:18:33.501+0900 I/MY_LOG  (26920): change
06-03 12:18:33.501+0900 I/MY_LOG  (26920): change
06-03 12:18:33.501+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:33.501+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:33.962+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970988740
06-03 12:18:34.092+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970988862
06-03 12:18:34.092+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-03 12:18:34.112+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x7c00002 FAILED!
06-03 12:18:34.152+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-03 12:18:34.152+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-03 12:18:34.162+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:18:34.162+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-03 12:18:34.192+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-03 12:18:34.202+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-03 12:18:34.202+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_hide(927) > [0;33mHide[0m
06-03 12:18:34.202+0900 E/ISE_MULTI(  837): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 505  rect->height : 505[0m
06-03 12:18:34.202+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
06-03 12:18:34.242+0900 I/ISE_MULTI(  837): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-03 12:18:34.322+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-03 12:18:34.793+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970989563
06-03 12:18:34.793+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970989563
06-03 12:18:34.913+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:34.923+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970989683
06-03 12:18:34.933+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[40]  Y[176] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:34.933+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:34.933+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:34.933+0900 I/MY_LOG  (26920): change
06-03 12:18:34.933+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=1[0m
06-03 12:18:34.943+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:34.943+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:35.103+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970989884
06-03 12:18:35.103+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970989884
06-03 12:18:35.203+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:35.223+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970990004
06-03 12:18:35.223+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[116]  Y[179] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:35.233+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:35.233+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:35.243+0900 I/MY_LOG  (26920): change
06-03 12:18:35.243+0900 I/MY_LOG  (26920): change
06-03 12:18:35.243+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:35.253+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=2[0m
06-03 12:18:35.253+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:35.403+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970990182
06-03 12:18:35.403+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970990182
06-03 12:18:35.483+0900 I/MY_LOG  (26920): change
06-03 12:18:35.493+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:35.533+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970990314
06-03 12:18:35.533+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[204]  Y[168] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:35.533+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:35.533+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:35.543+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=3[0m
06-03 12:18:35.543+0900 I/MY_LOG  (26920): change
06-03 12:18:35.543+0900 I/MY_LOG  (26920): change
06-03 12:18:35.543+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:35.543+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:35.643+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970990426
06-03 12:18:35.653+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970990426
06-03 12:18:35.744+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970990525
06-03 12:18:35.744+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[264]  Y[167] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:35.744+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:35.744+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:35.754+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=4[0m
06-03 12:18:35.754+0900 I/MY_LOG  (26920): change
06-03 12:18:35.754+0900 I/MY_LOG  (26920): change
06-03 12:18:35.764+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:35.764+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:35.764+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:36.855+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=970991525
06-03 12:18:36.855+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=970991625
06-03 12:18:36.855+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-03 12:18:36.875+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x7c00002 FAILED!
06-03 12:18:36.875+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-03 12:18:37.745+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=970992520
06-03 12:18:37.745+0900 I/MY_LOG  (26920): Button pressed
06-03 12:18:37.755+0900 I/MY_LOG  (26920): change
06-03 12:18:37.836+0900 E/EFL     (26920): ecore_x<26920> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=970992608
06-03 12:18:37.836+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:true][0m
06-03 12:18:37.846+0900 I/MY_LOG  (26920): Button unpressed
06-03 12:18:37.996+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 26920 pgid = 26920
06-03 12:18:37.996+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(26920)
06-03 12:18:37.996+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 12:18:38.036+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 12:18:38.036+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 12:18:38.036+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-03 12:18:38.046+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 26920
06-03 12:18:38.046+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[26920] terminate event is forwarded
06-03 12:18:38.046+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-03 12:18:38.046+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 26920, ]
06-03 12:18:38.046+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-03 12:18:38.046+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-03 12:18:38.046+0900 I/Tizen::App( 1233): (512) > Not registered pid(26920)
06-03 12:18:38.046+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-03 12:18:38.046+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-03 12:18:38.046+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 26920
06-03 12:18:38.046+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 26920
06-03 12:18:38.046+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2983
06-03 12:18:38.056+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-03 12:18:38.056+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 12:18:38.056+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 12:18:38.056+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-03 12:18:38.056+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-03 12:18:38.056+0900 E/RESOURCED(  678): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 12:18:38.056+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-03 12:18:38.066+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-03 12:18:38.066+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 26920.
06-03 12:18:38.076+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-03 12:18:38.076+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 12:18:38.076+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-03 12:18:38.076+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 12:18:38.096+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 12:18:38.106+0900 W/CRASH_MANAGER(27314): worker.c: worker_job(1199) > 0626920636c69149645991
