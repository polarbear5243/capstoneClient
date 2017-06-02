S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 31300
Date: 2017-05-31 23:54:35+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 31300, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00007a44
r2   = 0x00000006, r3   = 0xb41054c0
r4   = 0x00000002, r5   = 0xb4105000
r6   = 0xb67ff09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f2d708
r10  = 0xb786caa0, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbe947e34
lr   = 0xb66f5f18, pc   = 0xb66f4b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     71748 KB
Buffers:     76140 KB
Cached:     275228 KB
VmPeak:     125952 KB
VmSize:     124624 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29556 KB
VmRSS:       28540 KB
VmData:      36496 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35844 KB
VmPTE:          96 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 31300 TID = 31300
31300 31301 31813 31831 

Maps Information
afb82000 b0381000 rw-p [stack:31831]
b0fde000 b0fef000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0fff000 b1004000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1bc2000 b1bca000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bdb000 b1bdc000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bec000 b1c00000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c14000 b1c15000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c25000 b1c28000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c39000 b1c3a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c4a000 b1c4c000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c5c000 b1c5e000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c6e000 b1c7e000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c8e000 b1c9a000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cac000 b24ab000 rw-p [stack:31813]
b27dc000 b27e3000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27f6000 b27fc000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b280c000 b2838000 r-xp /opt/usr/apps/org.example.client/bin/client
b2991000 b2a74000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2aab000 b2ad3000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ae5000 b32e4000 rw-p [stack:31301]
b32e4000 b32e6000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32f6000 b3300000 r-xp /lib/libnss_files-2.20-2014.11.so
b3311000 b331a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b332b000 b333c000 r-xp /lib/libnsl-2.20-2014.11.so
b334f000 b3355000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3366000 b3367000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b338f000 b3396000 r-xp /usr/lib/libminizip.so.1.0.0
b33a6000 b33ab000 r-xp /usr/lib/libstorage.so.0.1
b33bb000 b341a000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3430000 b3444000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3454000 b3498000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34a8000 b34b0000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34c0000 b34f0000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3503000 b35bc000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35d0000 b3623000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3634000 b364f000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b365f000 b3720000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3733000 b3743000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3753000 b3760000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3771000 b3778000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3788000 b37c9000 r-xp /usr/lib/libmdm.so.1.2.12
b37d9000 b37e1000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37f0000 b3800000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3821000 b3881000 r-xp /usr/lib/libasound.so.2.0.0
b3893000 b3896000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38a6000 b38a9000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38b9000 b38be000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38ce000 b38cf000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38df000 b38ea000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38fe000 b3905000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3915000 b391b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b392b000 b3930000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3940000 b395b000 r-xp /usr/lib/libmmfsound.so.0.1.0
b396b000 b3972000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3982000 b3985000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3996000 b39c4000 r-xp /usr/lib/libidn.so.11.5.44
b39d4000 b39ea000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39fb000 b3a05000 r-xp /usr/lib/libcares.so.2.1.0
b3a15000 b3a1f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a2f000 b3a31000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a41000 b3a42000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a52000 b3a56000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a67000 b3a8f000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aa0000 b3ac9000 r-xp /usr/lib/libturbojpeg.so
b3ae9000 b3aef000 r-xp /usr/lib/libgif.so.4.1.6
b3aff000 b3b45000 r-xp /usr/lib/libcurl.so.4.3.0
b3b56000 b3b77000 r-xp /usr/lib/libexif.so.12.3.3
b3b92000 b3ba7000 r-xp /usr/lib/libtts.so
b3bb8000 b3bc0000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bd0000 b3c96000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cb6000 b3dae000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dcd000 b3e9b000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3eb2000 b3eb4000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ec4000 b3eca000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3eda000 b3efd000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f0e000 b3f10000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f20000 b3f22000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f33000 b3f38000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f4f000 b3f51000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f61000 b3f68000 r-xp /usr/lib/libsensord-share.so
b3f78000 b3f90000 r-xp /usr/lib/libsensor.so.1.1.0
b3fa1000 b3fa4000 r-xp /usr/lib/libXv.so.1.0.0
b3fb4000 b3fb9000 r-xp /usr/lib/libutilX.so.1.1.0
b3fc9000 b3fce000 r-xp /usr/lib/libappcore-common.so.1.1
b3fde000 b3fe5000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3ff8000 b3ffc000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b400d000 b40eb000 r-xp /usr/lib/libCOREGL.so.4.0
b410b000 b410e000 r-xp /usr/lib/libuuid.so.1.3.0
b411e000 b4135000 r-xp /usr/lib/libblkid.so.1.1.0
b4146000 b4148000 r-xp /usr/lib/libXau.so.6.0.0
b4158000 b419f000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41b1000 b41b7000 r-xp /usr/lib/libjson-c.so.2.0.1
b41c8000 b41cc000 r-xp /usr/lib/libogg.so.0.7.1
b41dc000 b41fe000 r-xp /usr/lib/libvorbis.so.0.4.3
b420e000 b42f2000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b430e000 b4311000 r-xp /usr/lib/libEGL.so.1.4
b4322000 b4328000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4338000 b433a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b434a000 b4357000 r-xp /usr/lib/libGLESv2.so.2.0
b4368000 b43ca000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43df000 b43f7000 r-xp /usr/lib/libmount.so.1.1.0
b4409000 b441d000 r-xp /usr/lib/libxcb.so.1.1.0
b442d000 b4434000 r-xp /lib/libcrypt-2.20-2014.11.so
b446c000 b446e000 r-xp /usr/lib/libiri.so
b447e000 b4489000 r-xp /usr/lib/libgpg-error.so.0.15.0
b449a000 b44d0000 r-xp /usr/lib/libpulse.so.0.16.2
b44e1000 b4524000 r-xp /usr/lib/libsndfile.so.1.0.25
b4539000 b454e000 r-xp /lib/libexpat.so.1.5.2
b4560000 b461e000 r-xp /usr/lib/libcairo.so.2.11200.14
b4632000 b463a000 r-xp /usr/lib/libdrm.so.2.4.0
b464a000 b464d000 r-xp /usr/lib/libdri2.so.0.0.0
b465d000 b46ab000 r-xp /usr/lib/libssl.so.1.0.0
b46c0000 b46cc000 r-xp /usr/lib/libeeze.so.1.13.0
b46dd000 b46e6000 r-xp /usr/lib/libethumb.so.1.13.0
b46f6000 b46f9000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4709000 b48c0000 r-xp /usr/lib/libcrypto.so.1.0.0
b56ab000 b56b4000 r-xp /usr/lib/libXi.so.6.1.0
b56c4000 b56c6000 r-xp /usr/lib/libXgesture.so.7.0.0
b56d6000 b56da000 r-xp /usr/lib/libXtst.so.6.1.0
b56ea000 b56f0000 r-xp /usr/lib/libXrender.so.1.3.0
b5700000 b5706000 r-xp /usr/lib/libXrandr.so.2.2.0
b5716000 b5718000 r-xp /usr/lib/libXinerama.so.1.0.0
b5729000 b572c000 r-xp /usr/lib/libXfixes.so.3.1.0
b573c000 b5747000 r-xp /usr/lib/libXext.so.6.4.0
b5757000 b5759000 r-xp /usr/lib/libXdamage.so.1.1.0
b5769000 b576b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b577b000 b585d000 r-xp /usr/lib/libX11.so.6.3.0
b5871000 b5878000 r-xp /usr/lib/libXcursor.so.1.0.2
b5888000 b58a0000 r-xp /usr/lib/libudev.so.1.6.0
b58a2000 b58a5000 r-xp /lib/libattr.so.1.1.0
b58b5000 b58d5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58d6000 b58db000 r-xp /usr/lib/libffi.so.6.0.2
b58ec000 b5904000 r-xp /lib/libz.so.1.2.8
b5914000 b5916000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5926000 b59fb000 r-xp /usr/lib/libxml2.so.2.9.2
b5a10000 b5aab000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ac7000 b5aca000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ada000 b5af3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b04000 b5b15000 r-xp /lib/libresolv-2.20-2014.11.so
b5b29000 b5ba3000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bb8000 b5bba000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bca000 b5bd1000 r-xp /usr/lib/libembryo.so.1.13.0
b5be1000 b5beb000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bfc000 b5c14000 r-xp /usr/lib/libpng12.so.0.50.0
b5c25000 b5c48000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c69000 b5c7d000 r-xp /usr/lib/libector.so.1.13.0
b5c8e000 b5ca6000 r-xp /usr/lib/liblua-5.1.so
b5cb7000 b5d0e000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d22000 b5d4a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d5b000 b5d6e000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d7f000 b5db9000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dca000 b5dd8000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5de8000 b5df0000 r-xp /usr/lib/libtbm.so.1.0.0
b5e00000 b5e0d000 r-xp /usr/lib/libeio.so.1.13.0
b5e1d000 b5e1f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e2f000 b5e34000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e44000 b5e5b000 r-xp /usr/lib/libefreet.so.1.13.0
b5e6d000 b5e8d000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e9d000 b5ebd000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ebf000 b5ec5000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ed5000 b5ee6000 r-xp /usr/lib/libemotion.so.1.13.0
b5ef7000 b5efe000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f0e000 b5f1d000 r-xp /usr/lib/libeo.so.1.13.0
b5f2e000 b5f40000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f51000 b5f56000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f66000 b5f7f000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f8f000 b5fac000 r-xp /usr/lib/libeet.so.1.13.0
b5fc5000 b600d000 r-xp /usr/lib/libeina.so.1.13.0
b601e000 b602e000 r-xp /usr/lib/libefl.so.1.13.0
b603f000 b6124000 r-xp /usr/lib/libicuuc.so.51.1
b6141000 b6281000 r-xp /usr/lib/libicui18n.so.51.1
b6298000 b62d0000 r-xp /usr/lib/libecore_x.so.1.13.0
b62e2000 b62e5000 r-xp /lib/libcap.so.2.21
b62f5000 b631e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b632f000 b6336000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6348000 b637f000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6390000 b647b000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b648e000 b6507000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6519000 b651e000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b652e000 b6538000 r-xp /usr/lib/libvconf.so.0.2.45
b6548000 b654a000 r-xp /usr/lib/libvasum.so.0.3.1
b655a000 b655c000 r-xp /usr/lib/libttrace.so.1.1
b656c000 b656f000 r-xp /usr/lib/libiniparser.so.0
b657f000 b65a5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65b5000 b65ba000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65cb000 b65e2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65f3000 b665e000 r-xp /lib/libm-2.20-2014.11.so
b666f000 b6675000 r-xp /lib/librt-2.20-2014.11.so
b6686000 b6693000 r-xp /usr/lib/libunwind.so.8.0.1
b66c9000 b67ed000 r-xp /lib/libc-2.20-2014.11.so
b6802000 b681b000 r-xp /lib/libgcc_s-4.9.so.1
b682b000 b690d000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b691e000 b6948000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6959000 b6995000 r-xp /usr/lib/libsystemd.so.0.4.0
b6997000 b6a1a000 r-xp /usr/lib/libedje.so.1.13.0
b6a2d000 b6a4b000 r-xp /usr/lib/libecore.so.1.13.0
b6a6b000 b6bf2000 r-xp /usr/lib/libevas.so.1.13.0
b6c27000 b6c3b000 r-xp /lib/libpthread-2.20-2014.11.so
b6c4f000 b6e83000 r-xp /usr/lib/libelementary.so.1.13.0
b6eb2000 b6eb6000 r-xp /usr/lib/libsmack.so.1.0.0
b6ec6000 b6ecd000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6edd000 b6edf000 r-xp /usr/lib/libdlog.so.0.0.0
b6eef000 b6ef2000 r-xp /usr/lib/libbundle.so.0.1.22
b6f02000 b6f04000 r-xp /lib/libdl-2.20-2014.11.so
b6f15000 b6f2d000 r-xp /usr/lib/libaul.so.0.1.0
b6f41000 b6f46000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f57000 b6f64000 r-xp /usr/lib/liblptcp.so
b6f76000 b6f7a000 r-xp /usr/lib/libsys-assert.so
b6f8b000 b6fab000 r-xp /lib/ld-2.20-2014.11.so
b6fbc000 b6fc1000 r-xp /usr/bin/launchpad-loader
b749a000 b788c000 rw-p [heap]
be928000 be949000 rw-p [stack]
be928000 be949000 rw-p [stack]
End of Maps Information

Callstack Information (PID:31300)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66f4b84) [/lib/libc.so.6] + 0x2bb84
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
ind_op_cbinfo(312) > tmp is NULL
05-31 23:53:38.709+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:38.709+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:38.709+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:38.709+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:38.709+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:38.709+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.581+0900 E/PKGMGR_SERVER(31696): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
05-31 23:53:40.681+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
05-31 23:53:40.681+0900 I/Tizen::App( 1233): (78) > Installation is Completed. [Package = org.example.client]
05-31 23:53:40.681+0900 I/Tizen::App( 1233): (671) > Enter. package(org.example.client), installationResult(0)
05-31 23:53:40.691+0900 I/Tizen::App( 1233): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
05-31 23:53:40.691+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.691+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.691+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.691+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
05-31 23:53:40.701+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
05-31 23:53:40.701+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR_SERVER(31696): pkgmgr-server.c: sighandler(417) > child NORMAL exit [31749]
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.701+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 23:53:40.721+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
05-31 23:53:40.721+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
05-31 23:53:40.721+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
05-31 23:53:40.721+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
05-31 23:53:40.721+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
05-31 23:53:40.721+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
05-31 23:53:40.741+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
05-31 23:53:40.741+0900 E/HOME_APPS(  867): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
05-31 23:53:40.741+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
05-31 23:53:40.741+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
05-31 23:53:40.741+0900 I/Tizen::App( 1233): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
05-31 23:53:40.751+0900 I/Tizen::App( 1233): (416) > appName = [client]
05-31 23:53:40.751+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
05-31 23:53:40.751+0900 E/PKGMGR_INFO( 1233): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
05-31 23:53:40.751+0900 I/Tizen::App( 1233): (683) > Application count(1) in this package
05-31 23:53:40.751+0900 I/Tizen::App( 1233): (840) > Enter.
05-31 23:53:40.751+0900 I/Tizen::App( 1233): (703) > Exit.
05-31 23:53:40.751+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
05-31 23:53:40.761+0900 E/util-view(  867): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
05-31 23:53:40.761+0900 I/Tizen::App( 1233): (416) > appName = [client]
05-31 23:53:40.761+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
05-31 23:53:40.761+0900 I/Tizen::App( 1233): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
05-31 23:53:40.771+0900 I/Tizen::App( 1233): (131) > Enter
05-31 23:53:40.771+0900 I/Tizen::App( 1233): (137) > org.example.client does not have launch condition
05-31 23:53:40.771+0900 I/Tizen::App( 1233): (883) > Exit.
05-31 23:53:40.781+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
05-31 23:53:42.583+0900 E/PKGMGR_SERVER(31696): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-31 23:53:42.583+0900 E/PKGMGR_SERVER(31696): pkgmgr-server.c: main(2471) > package manager server terminated.
05-31 23:53:44.965+0900 W/AUL     (31806): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
05-31 23:53:44.965+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
05-31 23:53:44.975+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
05-31 23:53:44.985+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
05-31 23:53:44.985+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
05-31 23:53:44.985+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 31806
05-31 23:53:44.985+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
05-31 23:53:45.005+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
05-31 23:53:45.005+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-31 23:53:45.005+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
05-31 23:53:45.005+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
05-31 23:53:45.005+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
05-31 23:53:45.025+0900 I/abc     (31300): abc
05-31 23:53:45.025+0900 I/CAPI_APPFW_APPLICATION(31300): app_main.c: ui_app_main(789) > app_efl_main
05-31 23:53:45.035+0900 I/CAPI_APPFW_APPLICATION(31300): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
05-31 23:53:45.085+0900 E/TBM     (31300): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
05-31 23:53:45.105+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 31300, appid: org.example.client
05-31 23:53:45.105+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
05-31 23:53:45.125+0900 W/AUL     (31806): launch.c: app_request_to_launchpad(425) > request cmd(0) result(31300)
05-31 23:53:45.936+0900 I/APP_CORE(31300): appcore-efl.c: __do_app(514) > [APP 31300] Event: RESET State: CREATED
05-31 23:53:45.936+0900 I/CAPI_APPFW_APPLICATION(31300): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
05-31 23:53:45.946+0900 E/EFL     (31300): edje<31300> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 23:53:45.946+0900 E/EFL     (31300): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 23:53:45.956+0900 E/EFL     (31300): edje<31300> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 23:53:45.956+0900 E/EFL     (31300): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 23:53:45.956+0900 E/EFL     (31300): edje<31300> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 23:53:45.956+0900 E/EFL     (31300): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 23:53:45.966+0900 W/APP_CORE(31300): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
05-31 23:53:45.966+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
05-31 23:53:46.086+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
05-31 23:53:46.086+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
05-31 23:53:46.086+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
05-31 23:53:46.106+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(31300) status(4)
05-31 23:53:46.106+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 23:53:46.106+0900 W/AUL_AMD (  612): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
05-31 23:53:46.146+0900 I/APP_CORE(31300): appcore-efl.c: __do_app(514) > [APP 31300] Event: PAUSE State: CREATED
05-31 23:53:46.176+0900 I/TIZEN_N_EFL_UTIL_WINDOW(31300): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 32
05-31 23:53:46.216+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1806
05-31 23:53:46.226+0900 E/APP_CORE(31300): appcore-efl.c: _capture_and_make_file(1619) > win[5800002] widget[720] height[1280]
05-31 23:53:46.256+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 33
05-31 23:53:46.266+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
05-31 23:53:46.266+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 31300.
05-31 23:53:46.436+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(31300) status(0)
05-31 23:53:47.357+0900 I/UXT     (31818): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
05-31 23:53:50.120+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(31300)
05-31 23:53:50.120+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 31300, appid: org.example.client, status: bg
05-31 23:53:53.103+0900 W/LOCKSCREEN(  850): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
05-31 23:53:53.103+0900 W/LOCKSCREEN(  850): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
05-31 23:53:53.103+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
05-31 23:53:53.103+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
05-31 23:53:53.103+0900 W/LOCKSCREEN(  850): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
05-31 23:53:53.103+0900 W/LOCKSCREEN(  850): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
05-31 23:53:53.113+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
05-31 23:53:53.113+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
05-31 23:53:53.123+0900 E/LOCKSCREEN(  850): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
05-31 23:53:53.133+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 11:53
05-31 23:53:53.133+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 11:53"
05-31 23:53:53.133+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 11:53"
05-31 23:53:53.133+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
05-31 23:53:53.133+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145920730 Time: <font_size=31> </font_size> <font_size=31> 오후 11:53</font_size></font>"
05-31 23:53:53.133+0900 I/INDICATOR(  676): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(1) / battery_charging(0)"
05-31 23:53:53.133+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
05-31 23:53:53.133+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 23:53:53.133+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 23:53:53.133+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 23:53:53.133+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 23:53:53.133+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 23:53:53.503+0900 W/LOCKSCREEN(  850): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
05-31 23:53:53.503+0900 W/LOCKSCREEN(  850): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
05-31 23:53:53.503+0900 W/APP_CORE(  850): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
05-31 23:53:53.503+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: RESUME State: PAUSED
05-31 23:53:53.503+0900 I/CAPI_APPFW_APPLICATION(  850): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 23:53:53.503+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
05-31 23:53:53.503+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
05-31 23:53:53.503+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
05-31 23:53:53.503+0900 E/LOCKSCREEN(  850): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
05-31 23:53:53.503+0900 W/AUL     (  850): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
05-31 23:53:53.503+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
05-31 23:53:53.503+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 850
05-31 23:53:53.503+0900 I/AUL_AMD (  612): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
05-31 23:53:53.513+0900 W/AUL_AMD (  612): amd_launch.c: start_process(638) > child process: 31822
05-31 23:53:53.513+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-31 23:53:53.573+0900 W/AUL_AMD (  612): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 31822
05-31 23:53:53.573+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 31822, appid: com.samsung.weather-m-agent
05-31 23:53:53.573+0900 W/AUL     (  850): launch.c: app_request_to_launchpad(425) > request cmd(0) result(31822)
05-31 23:53:53.583+0900 I/Tizen::App( 1233): (499) > LaunchedApp(com.samsung.weather-m-agent)
05-31 23:53:53.583+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 31822.
05-31 23:53:53.714+0900 E/weather-agent(31822): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
05-31 23:53:53.724+0900 E/weather-common(31822): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
05-31 23:53:53.724+0900 E/weather-agent(31822): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
05-31 23:53:53.734+0900 I/MESSAGE_PORT(31822): message-port.c: __initialize(872) > initialize
05-31 23:53:53.744+0900 I/MESSAGE_PORT(31822): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
05-31 23:53:53.754+0900 I/Tizen::System( 1233): (280) > The screen has been turned on.
05-31 23:53:53.754+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 23:53:53.764+0900 W/LOCKSCREEN(  850): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
05-31 23:53:53.764+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __message_port_send_message(972) > port exist check !!
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
05-31 23:53:53.774+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
05-31 23:53:53.774+0900 I/MESSAGE_PORT(  850): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __message_port_send_message(972) > port exist check !!
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
05-31 23:53:53.784+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 23:53:53.784+0900 E/MESSAGE_PORT(31822): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __message_port_send_message(972) > port exist check !!
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
05-31 23:53:53.784+0900 I/MESSAGE_PORT( 1310): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __message_port_send_message(972) > port exist check !!
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
05-31 23:53:53.784+0900 E/MESSAGE_PORT(31822): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : 흑석동[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Heukseok-dong[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 20.000000[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 29.800000[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 65.100000[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 18[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1496238734[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : On[0;m
05-31 23:53:53.784+0900 E/weather-agent(31822): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
05-31 23:53:53.784+0900 E/weather-agent(31822): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
05-31 23:53:53.794+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 23:53:53.804+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 23:53:53.844+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
05-31 23:53:53.844+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
05-31 23:53:53.974+0900 E/EFL     (  850): ecore_x<850> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798036395
05-31 23:53:54.064+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb82801b8]
05-31 23:53:54.064+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
05-31 23:53:54.064+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb82801b8
05-31 23:53:54.064+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
05-31 23:53:54.074+0900 W/LOCATION( 1310): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
05-31 23:53:54.074+0900 E/weather-common( 1310): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
05-31 23:53:54.094+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
05-31 23:53:54.094+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_update_cb(287) > received updating signal
05-31 23:53:54.094+0900 E/EFL     ( 1310): edje<1310> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 23:53:54.124+0900 E/EFL     ( 1310): evas_main<1310> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8001bf60 is not stable during recalc loop
05-31 23:53:54.164+0900 E/EFL     ( 1310): evas_main<1310> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8001bf60 is not stable during recalc loop
05-31 23:53:54.174+0900 E/EFL     ( 1310): edje<1310> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 23:53:54.194+0900 E/cluster-home(  867): cluster-data-list.cpp: GetDBoxID(1000) >  found id[5]
05-31 23:53:54.194+0900 W/cluster-view(  867): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
05-31 23:53:54.254+0900 E/EFL     (  850): ecore_x<850> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798036673
05-31 23:53:54.254+0900 E/LOCKSCREEN(  850): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
05-31 23:53:54.254+0900 E/LOCKSCREEN(  850): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
05-31 23:53:54.584+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
05-31 23:53:54.584+0900 W/LOCKSCREEN(  850): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
05-31 23:53:54.584+0900 W/LOCKSCREEN(  850): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
05-31 23:53:54.594+0900 E/LOCKSCREEN(  850): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
05-31 23:53:54.594+0900 E/LOCKSCREEN(  850): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
05-31 23:53:54.594+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
05-31 23:53:54.594+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
05-31 23:53:54.594+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
05-31 23:53:54.594+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
05-31 23:53:54.614+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 23:53:54.614+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(850) status(4)
05-31 23:53:54.614+0900 W/LOCKSCREEN(  850): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
05-31 23:53:54.614+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
05-31 23:53:54.614+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(850)
05-31 23:53:54.614+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
05-31 23:53:54.614+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 850, appid: com.samsung.lockscreen, status: bg
05-31 23:53:54.614+0900 E/LOCKSCREEN(  850): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
05-31 23:53:54.614+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: PAUSE State: RUNNING
05-31 23:53:54.614+0900 I/CAPI_APPFW_APPLICATION(  850): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
05-31 23:53:54.614+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
05-31 23:53:54.614+0900 E/LOCKSCREEN(  850): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
05-31 23:53:54.614+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
05-31 23:53:54.614+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
05-31 23:53:54.614+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
05-31 23:53:54.614+0900 E/LOCKSCREEN(  850): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
05-31 23:53:54.624+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 23:53:54.624+0900 I/APP_CORE(31300): appcore-efl.c: __do_app(514) > [APP 31300] Event: RESUME State: CREATED
05-31 23:53:54.644+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(31300) status(3)
05-31 23:53:54.644+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 23:53:54.644+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-31 23:53:54.644+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(31300)
05-31 23:53:54.644+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 31300, appid: org.example.client, status: fg
05-31 23:53:54.654+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: MEM_FLUSH State: PAUSED
05-31 23:53:54.664+0900 I/APP_CORE(31300): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
05-31 23:53:54.664+0900 I/APP_CORE(31300): appcore-efl.c: __do_app(625) > [APP 31300] Initial Launching, call the resume_cb
05-31 23:53:54.664+0900 I/CAPI_APPFW_APPLICATION(31300): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 23:53:54.674+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
05-31 23:53:54.674+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 23:53:54.674+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 23:53:54.684+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 23:53:54.725+0900 W/LOCKSCREEN(  850): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
05-31 23:53:54.725+0900 E/LOCKSCREEN(  850): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
05-31 23:53:54.725+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
05-31 23:53:54.725+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
05-31 23:53:54.725+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
05-31 23:53:54.725+0900 E/LOCKSCREEN(  850): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
05-31 23:53:54.795+0900 E/weather-agent(31822): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
05-31 23:53:54.795+0900 I/CAPI_APPFW_APPLICATION(31822): service_app_main.c: service_app_exit(446) > service_app_exit
05-31 23:53:54.795+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 22
05-31 23:53:54.795+0900 E/weather-agent(31822): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
05-31 23:53:54.795+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(1201) > app status : 5
05-31 23:53:54.915+0900 W/AUL_AMD (  612): amd_request.c: __send_app_termination_signal(609) > send dead signal done
05-31 23:53:54.925+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 31822
05-31 23:53:54.925+0900 I/Tizen::App( 1233): (243) > App[com.samsung.weather-m-agent] pid[31822] terminate event is forwarded
05-31 23:53:54.925+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
05-31 23:53:54.925+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 31822, ]
05-31 23:53:54.925+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
05-31 23:53:54.925+0900 I/Tizen::App( 1233): (506) > TerminatedApp(com.samsung.weather-m-agent)
05-31 23:53:54.925+0900 I/Tizen::App( 1233): (512) > Not registered pid(31822)
05-31 23:53:54.925+0900 I/Tizen::System( 1233): (246) > Terminated app [com.samsung.weather-m-agent]
05-31 23:53:54.925+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 23:53:54.925+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 31822
05-31 23:53:54.925+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 23:53:54.925+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 31822.
05-31 23:53:56.306+0900 E/EFL     (31300): ecore_x<31300> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798038727
05-31 23:53:56.316+0900 I/MY_LOG  (31300): Button pressed
05-31 23:53:56.406+0900 E/EFL     (31300): ecore_x<31300> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798038815
05-31 23:53:56.406+0900 E/VCONF   (31300): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
05-31 23:53:56.406+0900 E/VCONF   (31300): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
05-31 23:53:56.406+0900 E/VCONF   (31300): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
05-31 23:53:56.406+0900 E/VCONF   (31300): vconf.c: vconf_get_bool(2729) > vconf_get_bool(31300) : db/ise/keysound error
05-31 23:53:56.416+0900 E/VCONF   (31300): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
05-31 23:53:56.416+0900 E/VCONF   (31300): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
05-31 23:53:56.466+0900 I/MY_LOG  (31300): Button unpressed
05-31 23:53:57.097+0900 E/EFL     (31300): ecore_x<31300> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798039516
05-31 23:53:57.097+0900 I/MY_LOG  (31300): Button pressed
05-31 23:53:57.187+0900 E/EFL     (31300): ecore_x<31300> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798039605
05-31 23:53:57.187+0900 I/MY_LOG  (31300): Button unpressed
05-31 23:53:57.227+0900 D/basicui (31300): successed to load edc file
05-31 23:53:57.307+0900 I/MY_LOG  (31300): change
05-31 23:53:57.467+0900 I/MY_LOG  (31300): change
05-31 23:53:59.079+0900 E/EFL     (31300): ecore_x<31300> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798041497
05-31 23:53:59.089+0900 I/MY_LOG  (31300): Button pressed
05-31 23:53:59.179+0900 E/EFL     (31300): ecore_x<31300> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798041597
05-31 23:53:59.179+0900 I/MY_LOG  (31300): Button unpressed
05-31 23:53:59.189+0900 I/basicui (31300): (selected item : DEFAULT)
05-31 23:53:59.619+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: MEM_FLUSH State: PAUSED
05-31 23:53:59.799+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
05-31 23:54:00.130+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
05-31 23:54:00.130+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 11:54
05-31 23:54:00.130+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 11:54"
05-31 23:54:00.130+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 11:54"
05-31 23:54:00.130+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
05-31 23:54:00.130+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145897656 Time: <font_size=31> </font_size> <font_size=31> 오후 11:54</font_size></font>"
05-31 23:54:35.314+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 23:54:35.314+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
05-31 23:54:35.324+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 23:54:35.324+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-31 23:54:35.324+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
05-31 23:54:35.324+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
05-31 23:54:35.344+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 31300 pgid = 31300
05-31 23:54:35.344+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(31300)
05-31 23:54:35.354+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
05-31 23:54:35.384+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
05-31 23:54:35.384+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 23:54:35.384+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
05-31 23:54:35.384+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 23:54:35.404+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
05-31 23:54:35.414+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
05-31 23:54:35.414+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
05-31 23:54:35.414+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
05-31 23:54:35.414+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 31300
05-31 23:54:35.424+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 31300
05-31 23:54:35.424+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 31300
05-31 23:54:35.434+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
05-31 23:54:35.444+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
05-31 23:54:35.444+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 23:54:35.444+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1812
05-31 23:54:35.454+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
05-31 23:54:35.454+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 23:54:35.454+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
05-31 23:54:35.454+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 23:54:35.474+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 23:54:35.474+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[31300] terminate event is forwarded
05-31 23:54:35.474+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
05-31 23:54:35.474+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 31300, ]
05-31 23:54:35.474+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
05-31 23:54:35.474+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
05-31 23:54:35.474+0900 I/Tizen::App( 1233): (512) > Not registered pid(31300)
05-31 23:54:35.474+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
05-31 23:54:35.474+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 23:54:35.474+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 23:54:35.494+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 23:54:35.494+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 31300.
05-31 23:54:35.504+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
05-31 23:54:35.534+0900 W/CRASH_MANAGER(31837): worker.c: worker_job(1199) > 0631300636c69149624247
