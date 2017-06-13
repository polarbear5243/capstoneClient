S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 19191
Date: 2017-06-13 14:11:50+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 19191, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00004af7
r2   = 0x00000006, r3   = 0xb40d44c0
r4   = 0x00000002, r5   = 0xb40d4000
r6   = 0xb67ce09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb80952a8
r10  = 0xbed55498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbed550dc
lr   = 0xb66c4f18, pc   = 0xb66c3b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     54168 KB
Buffers:     65264 KB
Cached:     239916 KB
VmPeak:      90468 KB
VmSize:      90464 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19620 KB
VmRSS:       19620 KB
VmData:      22012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 19191 TID = 19191
19191 19192 19479 

Maps Information
b1b9d000 b1ba5000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bb6000 b1bb7000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bc7000 b1bdb000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bef000 b1bf0000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c00000 b1c03000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c14000 b1c15000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c25000 b1c27000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c37000 b1c39000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c49000 b1c59000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c69000 b1c75000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c87000 b2486000 rw-p [stack:19479]
b27b7000 b27be000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27d1000 b27d7000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27e7000 b2817000 r-xp /opt/usr/apps/org.example.client/bin/client
b2960000 b2a43000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a7a000 b2aa2000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ab4000 b32b3000 rw-p [stack:19192]
b32b3000 b32b5000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32c5000 b32cf000 r-xp /lib/libnss_files-2.20-2014.11.so
b32e0000 b32e9000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32fa000 b330b000 r-xp /lib/libnsl-2.20-2014.11.so
b331e000 b3324000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3335000 b3336000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b335e000 b3365000 r-xp /usr/lib/libminizip.so.1.0.0
b3375000 b337a000 r-xp /usr/lib/libstorage.so.0.1
b338a000 b33e9000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33ff000 b3413000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3423000 b3467000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3477000 b347f000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b348f000 b34bf000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34d2000 b358b000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b359f000 b35f2000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3603000 b361e000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b362e000 b36ef000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3702000 b3712000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3722000 b372f000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3740000 b3747000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3757000 b3798000 r-xp /usr/lib/libmdm.so.1.2.12
b37a8000 b37b0000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37bf000 b37cf000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37f0000 b3850000 r-xp /usr/lib/libasound.so.2.0.0
b3862000 b3865000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3875000 b3878000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3888000 b388d000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b389d000 b389e000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38ae000 b38b9000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38cd000 b38d4000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38e4000 b38ea000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38fa000 b38ff000 r-xp /usr/lib/libmmfsession.so.0.0.1
b390f000 b392a000 r-xp /usr/lib/libmmfsound.so.0.1.0
b393a000 b3941000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3951000 b3954000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3965000 b3993000 r-xp /usr/lib/libidn.so.11.5.44
b39a3000 b39b9000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39ca000 b39d4000 r-xp /usr/lib/libcares.so.2.1.0
b39e4000 b39ee000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39fe000 b3a00000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a10000 b3a11000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a21000 b3a25000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a36000 b3a5e000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a6f000 b3a98000 r-xp /usr/lib/libturbojpeg.so
b3ab8000 b3abe000 r-xp /usr/lib/libgif.so.4.1.6
b3ace000 b3b14000 r-xp /usr/lib/libcurl.so.4.3.0
b3b25000 b3b46000 r-xp /usr/lib/libexif.so.12.3.3
b3b61000 b3b76000 r-xp /usr/lib/libtts.so
b3b87000 b3b8f000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b9f000 b3c65000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c85000 b3d7d000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d9c000 b3e6a000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e81000 b3e83000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e93000 b3e99000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ea9000 b3ecc000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3edd000 b3edf000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eef000 b3ef1000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f02000 b3f07000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f1e000 b3f20000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f30000 b3f37000 r-xp /usr/lib/libsensord-share.so
b3f47000 b3f5f000 r-xp /usr/lib/libsensor.so.1.1.0
b3f70000 b3f73000 r-xp /usr/lib/libXv.so.1.0.0
b3f83000 b3f88000 r-xp /usr/lib/libutilX.so.1.1.0
b3f98000 b3f9d000 r-xp /usr/lib/libappcore-common.so.1.1
b3fad000 b3fb4000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fc7000 b3fcb000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fdc000 b40ba000 r-xp /usr/lib/libCOREGL.so.4.0
b40da000 b40dd000 r-xp /usr/lib/libuuid.so.1.3.0
b40ed000 b4104000 r-xp /usr/lib/libblkid.so.1.1.0
b4115000 b4117000 r-xp /usr/lib/libXau.so.6.0.0
b4127000 b416e000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4180000 b4186000 r-xp /usr/lib/libjson-c.so.2.0.1
b4197000 b419b000 r-xp /usr/lib/libogg.so.0.7.1
b41ab000 b41cd000 r-xp /usr/lib/libvorbis.so.0.4.3
b41dd000 b42c1000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42dd000 b42e0000 r-xp /usr/lib/libEGL.so.1.4
b42f1000 b42f7000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4307000 b4309000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4319000 b4326000 r-xp /usr/lib/libGLESv2.so.2.0
b4337000 b4399000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43ae000 b43c6000 r-xp /usr/lib/libmount.so.1.1.0
b43d8000 b43ec000 r-xp /usr/lib/libxcb.so.1.1.0
b43fc000 b4403000 r-xp /lib/libcrypt-2.20-2014.11.so
b443b000 b443d000 r-xp /usr/lib/libiri.so
b444d000 b4458000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4469000 b449f000 r-xp /usr/lib/libpulse.so.0.16.2
b44b0000 b44f3000 r-xp /usr/lib/libsndfile.so.1.0.25
b4508000 b451d000 r-xp /lib/libexpat.so.1.5.2
b452f000 b45ed000 r-xp /usr/lib/libcairo.so.2.11200.14
b4601000 b4609000 r-xp /usr/lib/libdrm.so.2.4.0
b4619000 b461c000 r-xp /usr/lib/libdri2.so.0.0.0
b462c000 b467a000 r-xp /usr/lib/libssl.so.1.0.0
b468f000 b469b000 r-xp /usr/lib/libeeze.so.1.13.0
b46ac000 b46b5000 r-xp /usr/lib/libethumb.so.1.13.0
b46c5000 b46c8000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46d8000 b488f000 r-xp /usr/lib/libcrypto.so.1.0.0
b567a000 b5683000 r-xp /usr/lib/libXi.so.6.1.0
b5693000 b5695000 r-xp /usr/lib/libXgesture.so.7.0.0
b56a5000 b56a9000 r-xp /usr/lib/libXtst.so.6.1.0
b56b9000 b56bf000 r-xp /usr/lib/libXrender.so.1.3.0
b56cf000 b56d5000 r-xp /usr/lib/libXrandr.so.2.2.0
b56e5000 b56e7000 r-xp /usr/lib/libXinerama.so.1.0.0
b56f8000 b56fb000 r-xp /usr/lib/libXfixes.so.3.1.0
b570b000 b5716000 r-xp /usr/lib/libXext.so.6.4.0
b5726000 b5728000 r-xp /usr/lib/libXdamage.so.1.1.0
b5738000 b573a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b574a000 b582c000 r-xp /usr/lib/libX11.so.6.3.0
b5840000 b5847000 r-xp /usr/lib/libXcursor.so.1.0.2
b5857000 b586f000 r-xp /usr/lib/libudev.so.1.6.0
b5871000 b5874000 r-xp /lib/libattr.so.1.1.0
b5884000 b58a4000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58a5000 b58aa000 r-xp /usr/lib/libffi.so.6.0.2
b58bb000 b58d3000 r-xp /lib/libz.so.1.2.8
b58e3000 b58e5000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58f5000 b59ca000 r-xp /usr/lib/libxml2.so.2.9.2
b59df000 b5a7a000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a96000 b5a99000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aa9000 b5ac2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ad3000 b5ae4000 r-xp /lib/libresolv-2.20-2014.11.so
b5af8000 b5b72000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b87000 b5b89000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b99000 b5ba0000 r-xp /usr/lib/libembryo.so.1.13.0
b5bb0000 b5bba000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bcb000 b5be3000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf4000 b5c17000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c38000 b5c4c000 r-xp /usr/lib/libector.so.1.13.0
b5c5d000 b5c75000 r-xp /usr/lib/liblua-5.1.so
b5c86000 b5cdd000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cf1000 b5d19000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d2a000 b5d3d000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d4e000 b5d88000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d99000 b5da7000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5db7000 b5dbf000 r-xp /usr/lib/libtbm.so.1.0.0
b5dcf000 b5ddc000 r-xp /usr/lib/libeio.so.1.13.0
b5dec000 b5dee000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dfe000 b5e03000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e13000 b5e2a000 r-xp /usr/lib/libefreet.so.1.13.0
b5e3c000 b5e5c000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e6c000 b5e8c000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e8e000 b5e94000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea4000 b5eb5000 r-xp /usr/lib/libemotion.so.1.13.0
b5ec6000 b5ecd000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5edd000 b5eec000 r-xp /usr/lib/libeo.so.1.13.0
b5efd000 b5f0f000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f20000 b5f25000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f35000 b5f4e000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f5e000 b5f7b000 r-xp /usr/lib/libeet.so.1.13.0
b5f94000 b5fdc000 r-xp /usr/lib/libeina.so.1.13.0
b5fed000 b5ffd000 r-xp /usr/lib/libefl.so.1.13.0
b600e000 b60f3000 r-xp /usr/lib/libicuuc.so.51.1
b6110000 b6250000 r-xp /usr/lib/libicui18n.so.51.1
b6267000 b629f000 r-xp /usr/lib/libecore_x.so.1.13.0
b62b1000 b62b4000 r-xp /lib/libcap.so.2.21
b62c4000 b62ed000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62fe000 b6305000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6317000 b634e000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b635f000 b644a000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b645d000 b64d6000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64e8000 b64ed000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64fd000 b6507000 r-xp /usr/lib/libvconf.so.0.2.45
b6517000 b6519000 r-xp /usr/lib/libvasum.so.0.3.1
b6529000 b652b000 r-xp /usr/lib/libttrace.so.1.1
b653b000 b653e000 r-xp /usr/lib/libiniparser.so.0
b654e000 b6574000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6584000 b6589000 r-xp /usr/lib/libxdgmime.so.1.1.0
b659a000 b65b1000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c2000 b662d000 r-xp /lib/libm-2.20-2014.11.so
b663e000 b6644000 r-xp /lib/librt-2.20-2014.11.so
b6655000 b6662000 r-xp /usr/lib/libunwind.so.8.0.1
b6698000 b67bc000 r-xp /lib/libc-2.20-2014.11.so
b67d1000 b67ea000 r-xp /lib/libgcc_s-4.9.so.1
b67fa000 b68dc000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68ed000 b6917000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6928000 b6964000 r-xp /usr/lib/libsystemd.so.0.4.0
b6966000 b69e9000 r-xp /usr/lib/libedje.so.1.13.0
b69fc000 b6a1a000 r-xp /usr/lib/libecore.so.1.13.0
b6a3a000 b6bc1000 r-xp /usr/lib/libevas.so.1.13.0
b6bf6000 b6c0a000 r-xp /lib/libpthread-2.20-2014.11.so
b6c1e000 b6e52000 r-xp /usr/lib/libelementary.so.1.13.0
b6e81000 b6e85000 r-xp /usr/lib/libsmack.so.1.0.0
b6e95000 b6e9c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eac000 b6eae000 r-xp /usr/lib/libdlog.so.0.0.0
b6ebe000 b6ec1000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed1000 b6ed3000 r-xp /lib/libdl-2.20-2014.11.so
b6ee4000 b6efc000 r-xp /usr/lib/libaul.so.0.1.0
b6f10000 b6f15000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f26000 b6f33000 r-xp /usr/lib/liblptcp.so
b6f45000 b6f49000 r-xp /usr/lib/libsys-assert.so
b6f5a000 b6f7a000 r-xp /lib/ld-2.20-2014.11.so
b6f8b000 b6f90000 r-xp /usr/bin/launchpad-loader
b8054000 b8299000 rw-p [heap]
bed35000 bed56000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19191)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66c3b84) [/lib/libc.so.6] + 0x2bb84
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
( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:06.377+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:06.387+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:06.387+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:06.407+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:06.407+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:06.427+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:06.427+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:07.418+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: MEM_FLUSH State: PAUSED
06-13 14:11:09.250+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:11:09.250+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:11:09.560+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:11:13.724+0900 E/AUL_AMD (  607): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
06-13 14:11:18.699+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17664916
06-13 14:11:18.699+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 14:11:18.699+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17664916
06-13 14:11:18.709+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 14:11:18.709+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 14:11:19.009+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:11:19.009+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:11:19.009+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:11:19.009+0900 E/STARTER (  721): )
06-13 14:11:19.019+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:11:19.019+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:11:19.019+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:11:19.029+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 14:11:19.029+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:11:19.039+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 14:11:19.039+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:11:19.039+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 14:11:19.039+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:11:19.059+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:11:19.059+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:11:19.059+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:11:19.059+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:11:19.079+0900 E/CAPI_APPFW_APPLICATION(19212): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:11:19.079+0900 E/CAPI_APPFW_APPLICATION(19212): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:11:19.079+0900 E/CAPI_APPFW_APPLICATION(19212): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:11:19.079+0900 E/CAPI_APPFW_APPLICATION(19212): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:11:19.079+0900 E/CAPI_APPFW_APPLICATION(19212): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:11:19.079+0900 I/CAPI_APPFW_APPLICATION(19212): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:11:19.079+0900 I/CAPI_APPFW_APPLICATION(19212): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:11:19.149+0900 W/TASK_MGR_LITE(19212): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 14:11:19.149+0900 I/GXT_SIB (19212): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:11:19.159+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 19212, appid: com.samsung.task-mgr
06-13 14:11:19.159+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:11:19.179+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(19212)
06-13 14:11:19.179+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 14:11:19.189+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:11:19.189+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:11:19.229+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:11:19.229+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:11:19.249+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:11:19.259+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:11:19.269+0900 E/RUA     (19212): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 23, ncols : 5
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:11:19.269+0900 E/TASK_MGR_LITE(19212): recent_apps.c: list_unretrieve_item(213) > (NULL == item) -> list_unretrieve_item() return
06-13 14:11:19.299+0900 I/APP_CORE(19212): appcore-efl.c: __do_app(514) > [APP 19212] Event: RESET State: CREATED
06-13 14:11:19.299+0900 I/CAPI_APPFW_APPLICATION(19212): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:11:19.299+0900 E/EFL     (19212): edje<19212> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:11:19.299+0900 E/EFL     (19212): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:11:19.299+0900 E/EFL     (19212): edje<19212> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:11:19.299+0900 E/EFL     (19212): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:11:19.299+0900 W/APP_CORE(19212): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3200003
06-13 14:11:19.299+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 14:11:19.339+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 14:11:19.339+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:11:19.339+0900 I/APP_CORE(19212): appcore-efl.c: __do_app(514) > [APP 19212] Event: RESUME State: CREATED
06-13 14:11:19.339+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 14:11:19.339+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 14:11:19.339+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 14:11:19.339+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 14:11:19.350+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(19212) status(3)
06-13 14:11:19.350+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:11:19.350+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:11:19.350+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(19212)
06-13 14:11:19.350+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19212, appid: com.samsung.task-mgr, status: fg
06-13 14:11:19.350+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:11:19.350+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:11:19.350+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: bg
06-13 14:11:19.360+0900 I/APP_CORE(19212): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 14:11:19.360+0900 I/APP_CORE(19212): appcore-efl.c: __do_app(625) > [APP 19212] Initial Launching, call the resume_cb
06-13 14:11:19.360+0900 I/CAPI_APPFW_APPLICATION(19212): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:11:19.710+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(19212) status(0)
06-13 14:11:19.710+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:11:19.710+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17665917
06-13 14:11:19.710+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17665917
06-13 14:11:19.710+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:11:19.720+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:11:19.720+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:11:19.720+0900 E/STARTER (  721): )
06-13 14:11:19.720+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:11:19.720+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:11:19.720+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:11:19.720+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:11:20.210+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1904
06-13 14:11:20.220+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:11:20.220+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 19212.
06-13 14:11:20.401+0900 E/EFL     (19212): ecore_x<19212> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17666546
06-13 14:11:20.401+0900 E/EFL     (19212): ecore_x<19212> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17666616
06-13 14:11:20.401+0900 I/TASK_MGR_LITE(19212): task-mgr-lite.c: on_hw_back(132) > Back key and Key down, so call elm_exit()
06-13 14:11:20.401+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:11:20.401+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:11:20.401+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(19212)
06-13 14:11:20.411+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19212, appid: com.samsung.task-mgr, status: bg
06-13 14:11:20.411+0900 I/CAPI_APPFW_APPLICATION(19212): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:11:20.411+0900 W/TASK_MGR_LITE(19212): task-mgr-lite.c: _pause_app(406) > 
06-13 14:11:20.411+0900 I/CAPI_APPFW_APPLICATION(19212): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:11:20.411+0900 E/TASK_MGR_LITE(19212): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:11:20.411+0900 E/APP_CORE(19212): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:11:20.421+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:11:20.421+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:11:20.421+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:11:20.421+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:11:20.421+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:11:20.421+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:11:20.451+0900 I/MALI    (19212): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=19212   close drm_fd=30 
06-13 14:11:20.461+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:11:20.491+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:11:20.491+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:11:20.491+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:11:20.491+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:11:20.511+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:11:20.531+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:11:20.531+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:11:20.541+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:11:20.541+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:11:20.541+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:11:20.561+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:20.561+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:20.741+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 19212 pgid = 19212
06-13 14:11:20.741+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(19212)
06-13 14:11:20.781+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:11:20.781+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:11:20.781+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:11:20.781+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[19212] terminate event is forwarded
06-13 14:11:20.781+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:11:20.781+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 19212, ]
06-13 14:11:20.791+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:11:20.791+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:11:20.791+0900 I/Tizen::App( 1175): (512) > Not registered pid(19212)
06-13 14:11:20.791+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:11:20.791+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:11:20.791+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 19212
06-13 14:11:20.791+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 19212
06-13 14:11:20.791+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 19212
06-13 14:11:20.801+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1905
06-13 14:11:20.811+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:11:20.811+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 19212.
06-13 14:11:21.321+0900 I/UXT     (19228): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:11:21.371+0900 E/TBM     (19228): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:11:21.371+0900 I/MALI    (19228): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=19228   open drm_fd=30 
06-13 14:11:21.502+0900 E/EFL     (19228): edje<19228> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:11:21.502+0900 E/EFL     (19228): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:11:21.502+0900 E/EFL     (19228): edje<19228> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:11:21.502+0900 E/EFL     (19228): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:11:21.502+0900 E/EFL     (19228): edje<19228> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:11:21.502+0900 E/EFL     (19228): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:11:21.542+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:21.542+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:21.562+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:21.562+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:21.572+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:21.582+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:21.592+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:21.602+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:21.612+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:21.612+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:21.632+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:21.632+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:21.652+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:21.652+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:21.672+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:21.672+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:21.682+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:21.692+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:21.702+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:21.702+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:21.722+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:21.722+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:21.742+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:11:21.742+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:25.415+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:11:33.263+0900 E/PKGMGR_SERVER(19268): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:11:33.323+0900 E/PKGMGR  (19266): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-13 14:11:33.363+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:11:33.373+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:11:33.373+0900 E/PKGMGR_SERVER(19268): pkgmgr-server.c: sighandler(417) > child NORMAL exit [19271]
06-13 14:11:35.796+0900 E/PKGMGR_SERVER(19268): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:11:35.796+0900 E/PKGMGR_SERVER(19268): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:11:38.048+0900 E/PKGMGR  (19357): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
06-13 14:11:38.128+0900 E/PKGMGR_SERVER(19359): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:11:38.178+0900 E/PKGMGR_SERVER(19359): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
06-13 14:11:38.188+0900 E/PKGMGR_SERVER(19359): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
06-13 14:11:38.188+0900 E/PKGMGR  (19357): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[193570002]
06-13 14:11:38.338+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
06-13 14:11:38.338+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
06-13 14:11:38.338+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:38.338+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:38.348+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
06-13 14:11:38.358+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 14:11:38.358+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 14:11:38.358+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
06-13 14:11:38.358+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:38.358+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:38.638+0900 E/rpm-installer(19362): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
06-13 14:11:38.638+0900 E/rpm-installer(19362): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
06-13 14:11:38.698+0900 E/PKGMGR_PARSER(19362): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
06-13 14:11:38.708+0900 I/PRIVACY-MANAGER-CLIENT(19362): SocketClient.cpp: SocketClient(37) > Client created
06-13 14:11:38.708+0900 I/PRIVACY-MANAGER-CLIENT(19362): SocketClient.cpp: connect(62) > Client connected
06-13 14:11:38.708+0900 I/PRIVACY-MANAGER-SERVER(  914): SocketService.cpp: mainloop(230) > Got incoming connection
06-13 14:11:38.718+0900 I/PRIVACY-MANAGER-CLIENT(19362): SocketClient.cpp: disconnect(72) > Client disconnected
06-13 14:11:38.718+0900 E/PKGMGR_CERT(19362): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-13 14:11:38.718+0900 E/PKGMGR_CERT(19362): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-13 14:11:38.728+0900 E/PKGMGR_CERT(19362): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-13 14:11:38.758+0900 E/rpm-installer(19362): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
06-13 14:11:38.768+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:38.768+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
06-13 14:11:38.768+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:38.768+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
06-13 14:11:38.768+0900 E/ESD     (  898): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
06-13 14:11:38.778+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
06-13 14:11:38.778+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
06-13 14:11:38.778+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
06-13 14:11:40.420+0900 E/PKGMGR_SERVER(19359): pkgmgr-server.c: sighandler(417) > child NORMAL exit [19362]
06-13 14:11:40.790+0900 E/PKGMGR_SERVER(19359): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:11:40.790+0900 E/PKGMGR_SERVER(19359): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:11:42.672+0900 E/PKGMGR  (19411): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-13 14:11:42.752+0900 E/PKGMGR_SERVER(19413): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:11:42.802+0900 E/PKGMGR_SERVER(19413): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
06-13 14:11:42.812+0900 E/PKGMGR_INFO(19413): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
06-13 14:11:42.822+0900 E/rpm-installer(19413): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-13 14:11:42.832+0900 E/PKGMGR_SERVER(19413): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-13 14:11:42.832+0900 E/PKGMGR  (19411): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[194110002]
06-13 14:11:42.953+0900 E/PKGMGR_INSTALLER(19416): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-13 14:11:42.953+0900 E/rpm-installer(19416): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
06-13 14:11:42.973+0900 E/rpm-installer(19416): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-13 14:11:42.973+0900 E/rpm-installer(19416): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-13 14:11:42.973+0900 E/rpm-installer(19416): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:11:42.973+0900 E/rpm-installer(19416): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-13 14:11:42.973+0900 E/rpm-installer(19416): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:11:43.073+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
06-13 14:11:43.073+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
06-13 14:11:43.073+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:43.073+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:43.083+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 14:11:43.083+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 14:11:43.083+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
06-13 14:11:43.093+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:43.093+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:43.343+0900 I/Tizen::System( 1175): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
06-13 14:11:43.373+0900 E/rpm-installer(19416): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-13 14:11:43.373+0900 E/rpm-installer(19416): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-13 14:11:43.373+0900 E/rpm-installer(19416): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-13 14:11:43.373+0900 E/rpm-installer(19416): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:11:43.373+0900 E/rpm-installer(19416): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-13 14:11:43.383+0900 E/rpm-installer(19416): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-13 14:11:43.383+0900 E/PKGMGR_PARSER(19416): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-13 14:11:43.383+0900 E/PKGMGR_PARSER(19416): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-13 14:11:43.423+0900 I/PRIVACY-MANAGER-CLIENT(19416): SocketClient.cpp: SocketClient(37) > Client created
06-13 14:11:43.633+0900 E/PKGMGR_PARSER(19416): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-13 14:11:43.653+0900 E/PKGMGR_CERT(19416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-13 14:11:43.653+0900 E/PKGMGR_CERT(19416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-13 14:11:43.653+0900 E/PKGMGR_CERT(19416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-13 14:11:43.653+0900 E/PKGMGR_CERT(19416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 1
06-13 14:11:43.653+0900 E/PKGMGR_CERT(19416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 2
06-13 14:11:43.653+0900 E/PKGMGR_CERT(19416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 39 2
06-13 14:11:43.653+0900 E/PKGMGR_CERT(19416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 1
06-13 14:11:43.663+0900 E/PKGMGR_CERT(19416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-13 14:11:43.663+0900 E/rpm-installer(19416): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.client/lib]
06-13 14:11:43.663+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:43.663+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-13 14:11:43.663+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:43.663+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [60]
06-13 14:11:43.663+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
06-13 14:11:43.683+0900 E/rpm-installer(19416): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:11:43.703+0900 E/rpm-installer(19416): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-13 14:11:43.703+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:43.703+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:43.703+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-13 14:11:43.703+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [100]
06-13 14:11:43.703+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
06-13 14:11:44.794+0900 E/PKGMGR_SERVER(19413): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 14:11:45.545+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:45.545+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:11:45.545+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-13 14:11:45.545+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-13 14:11:45.545+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-13 14:11:45.545+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-13 14:11:45.545+0900 I/Tizen::App( 1175): (78) > Installation is Completed. [Package = org.example.client]
06-13 14:11:45.545+0900 I/Tizen::App( 1175): (671) > Enter. package(org.example.client), installationResult(0)
06-13 14:11:45.545+0900 I/Tizen::App( 1175): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-13 14:11:45.565+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-13 14:11:45.565+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-13 14:11:45.565+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-13 14:11:45.565+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-13 14:11:45.565+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-13 14:11:45.575+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-13 14:11:45.575+0900 E/HOME_APPS( 1167): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-13 14:11:45.575+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-13 14:11:45.575+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-13 14:11:45.585+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-13 14:11:45.585+0900 E/PKGMGR_SERVER(19413): pkgmgr-server.c: sighandler(417) > child NORMAL exit [19416]
06-13 14:11:45.595+0900 I/Tizen::App( 1175): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-13 14:11:45.605+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:11:45.605+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:11:45.605+0900 E/PKGMGR_INFO( 1175): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-13 14:11:45.605+0900 I/Tizen::App( 1175): (683) > Application count(1) in this package
06-13 14:11:45.605+0900 I/Tizen::App( 1175): (840) > Enter.
06-13 14:11:45.605+0900 I/Tizen::App( 1175): (703) > Exit.
06-13 14:11:45.605+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
06-13 14:11:45.615+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:11:45.615+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-13 14:11:45.615+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:11:45.615+0900 I/Tizen::App( 1175): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-13 14:11:45.615+0900 I/Tizen::App( 1175): (131) > Enter
06-13 14:11:45.615+0900 I/Tizen::App( 1175): (137) > org.example.client does not have launch condition
06-13 14:11:45.615+0900 I/Tizen::App( 1175): (883) > Exit.
06-13 14:11:45.645+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-13 14:11:46.796+0900 E/PKGMGR_SERVER(19413): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:11:46.796+0900 E/PKGMGR_SERVER(19413): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:11:47.047+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17693248
06-13 14:11:47.047+0900 I/Tizen::System( 1175): (280) > The screen has been turned on.
06-13 14:11:47.047+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:11:47.077+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:11:47.077+0900 I/Tizen::System( 1175): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
06-13 14:11:47.157+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:11:47.167+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:11:47.167+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:11:47.167+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:11:47.167+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:11:47.167+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:11:47.177+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:11:47.177+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:11:47.177+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:11:47.177+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:11:47.177+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:11:47.177+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:11:47.287+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:11:47.287+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:11:47.847+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17694053
06-13 14:11:48.108+0900 W/cluster-view( 1167): custom-cluster-impl.cpp: OnCustomScrollComplete(8717) >  booster timer is still running on cluster-view, Stop boost timer!!!
06-13 14:11:49.889+0900 W/AUL     (19472): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 14:11:49.889+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:11:49.899+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-13 14:11:49.899+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-13 14:11:49.899+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:11:49.899+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 19472
06-13 14:11:49.899+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:11:49.909+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 7
06-13 14:11:49.909+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:11:49.919+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:11:49.919+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:11:49.919+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:11:49.929+0900 I/abc     (19191): abc
06-13 14:11:49.929+0900 I/CAPI_APPFW_APPLICATION(19191): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:11:49.939+0900 I/CAPI_APPFW_APPLICATION(19191): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:11:49.969+0900 E/TBM     (19191): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:11:50.019+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 19191, appid: org.example.client
06-13 14:11:50.019+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:11:50.029+0900 W/AUL     (19472): launch.c: app_request_to_launchpad(425) > request cmd(0) result(19191)
06-13 14:11:50.240+0900 W/CRASH_MANAGER(19486): worker.c: worker_job(1199) > 0619191636c69149733071
