S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 1675
Date: 2017-04-03 03:18:00+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 1675, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x0000068b
r2   = 0x00000006, r3   = 0xb40ae4c0
r4   = 0x00000002, r5   = 0xb40ae000
r6   = 0xb67a809c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb84dd2a8
r10  = 0xbeae1498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbeae1024
lr   = 0xb669ef18, pc   = 0xb669db84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    236692 KB
Buffers:     32828 KB
Cached:     310524 KB
VmPeak:      98496 KB
VmSize:      98492 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19484 KB
VmRSS:       19484 KB
VmData:      30108 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35652 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 1675 TID = 1675
1675 1683 2096 2097 

Maps Information
b1386000 b138e000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13a0000 b1b9f000 rw-p [stack:2097]
b1b9f000 b1ba0000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bb0000 b1bc4000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bd8000 b1bd9000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1be9000 b1bec000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bfd000 b1bfe000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c0e000 b1c10000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c20000 b1c22000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c32000 b1c42000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c52000 b1c5e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c70000 b246f000 rw-p [stack:2096]
b27a0000 b27a7000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27ba000 b27c0000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27d0000 b27e2000 r-xp /opt/usr/apps/org.example.client/bin/client
b293a000 b2a1d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a54000 b2a7c000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a8e000 b328d000 rw-p [stack:1683]
b328d000 b328f000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b329f000 b32a9000 r-xp /lib/libnss_files-2.20-2014.11.so
b32ba000 b32c3000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32d4000 b32e5000 r-xp /lib/libnsl-2.20-2014.11.so
b32f8000 b32fe000 r-xp /lib/libnss_compat-2.20-2014.11.so
b330f000 b3310000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3338000 b333f000 r-xp /usr/lib/libminizip.so.1.0.0
b334f000 b3354000 r-xp /usr/lib/libstorage.so.0.1
b3364000 b33c3000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33d9000 b33ed000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33fd000 b3441000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3451000 b3459000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3469000 b3499000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34ac000 b3565000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3579000 b35cc000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35dd000 b35f8000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3608000 b36c9000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36dc000 b36ec000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36fc000 b3709000 r-xp /usr/lib/libmdm-common.so.1.0.98
b371a000 b3721000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3731000 b3772000 r-xp /usr/lib/libmdm.so.1.2.12
b3782000 b378a000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3799000 b37a9000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37ca000 b382a000 r-xp /usr/lib/libasound.so.2.0.0
b383c000 b383f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b384f000 b3852000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3862000 b3867000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3877000 b3878000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3888000 b3893000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38a7000 b38ae000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38be000 b38c4000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38d4000 b38d9000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38e9000 b3904000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3914000 b391b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b392b000 b392e000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b393f000 b396d000 r-xp /usr/lib/libidn.so.11.5.44
b397d000 b3993000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39a4000 b39ae000 r-xp /usr/lib/libcares.so.2.1.0
b39be000 b39c8000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39d8000 b39da000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ea000 b39eb000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39fb000 b39ff000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a10000 b3a38000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a49000 b3a72000 r-xp /usr/lib/libturbojpeg.so
b3a92000 b3a98000 r-xp /usr/lib/libgif.so.4.1.6
b3aa8000 b3aee000 r-xp /usr/lib/libcurl.so.4.3.0
b3aff000 b3b20000 r-xp /usr/lib/libexif.so.12.3.3
b3b3b000 b3b50000 r-xp /usr/lib/libtts.so
b3b61000 b3b69000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b79000 b3c3f000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c5f000 b3d57000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d76000 b3e44000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e5b000 b3e5d000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e6d000 b3e73000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e83000 b3ea6000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3eb7000 b3eb9000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ec9000 b3ecb000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3edc000 b3ee1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ef8000 b3efa000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f0a000 b3f11000 r-xp /usr/lib/libsensord-share.so
b3f21000 b3f39000 r-xp /usr/lib/libsensor.so.1.1.0
b3f4a000 b3f4d000 r-xp /usr/lib/libXv.so.1.0.0
b3f5d000 b3f62000 r-xp /usr/lib/libutilX.so.1.1.0
b3f72000 b3f77000 r-xp /usr/lib/libappcore-common.so.1.1
b3f87000 b3f8e000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fa1000 b3fa5000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fb6000 b4094000 r-xp /usr/lib/libCOREGL.so.4.0
b40b4000 b40b7000 r-xp /usr/lib/libuuid.so.1.3.0
b40c7000 b40de000 r-xp /usr/lib/libblkid.so.1.1.0
b40ef000 b40f1000 r-xp /usr/lib/libXau.so.6.0.0
b4101000 b4148000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b415a000 b4160000 r-xp /usr/lib/libjson-c.so.2.0.1
b4171000 b4175000 r-xp /usr/lib/libogg.so.0.7.1
b4185000 b41a7000 r-xp /usr/lib/libvorbis.so.0.4.3
b41b7000 b429b000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42b7000 b42ba000 r-xp /usr/lib/libEGL.so.1.4
b42cb000 b42d1000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42e1000 b42e3000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42f3000 b4300000 r-xp /usr/lib/libGLESv2.so.2.0
b4311000 b4373000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4388000 b43a0000 r-xp /usr/lib/libmount.so.1.1.0
b43b2000 b43c6000 r-xp /usr/lib/libxcb.so.1.1.0
b43d6000 b43dd000 r-xp /lib/libcrypt-2.20-2014.11.so
b4415000 b4417000 r-xp /usr/lib/libiri.so
b4427000 b4432000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4443000 b4479000 r-xp /usr/lib/libpulse.so.0.16.2
b448a000 b44cd000 r-xp /usr/lib/libsndfile.so.1.0.25
b44e2000 b44f7000 r-xp /lib/libexpat.so.1.5.2
b4509000 b45c7000 r-xp /usr/lib/libcairo.so.2.11200.14
b45db000 b45e3000 r-xp /usr/lib/libdrm.so.2.4.0
b45f3000 b45f6000 r-xp /usr/lib/libdri2.so.0.0.0
b4606000 b4654000 r-xp /usr/lib/libssl.so.1.0.0
b4669000 b4675000 r-xp /usr/lib/libeeze.so.1.13.0
b4686000 b468f000 r-xp /usr/lib/libethumb.so.1.13.0
b469f000 b46a2000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46b2000 b4869000 r-xp /usr/lib/libcrypto.so.1.0.0
b5654000 b565d000 r-xp /usr/lib/libXi.so.6.1.0
b566d000 b566f000 r-xp /usr/lib/libXgesture.so.7.0.0
b567f000 b5683000 r-xp /usr/lib/libXtst.so.6.1.0
b5693000 b5699000 r-xp /usr/lib/libXrender.so.1.3.0
b56a9000 b56af000 r-xp /usr/lib/libXrandr.so.2.2.0
b56bf000 b56c1000 r-xp /usr/lib/libXinerama.so.1.0.0
b56d2000 b56d5000 r-xp /usr/lib/libXfixes.so.3.1.0
b56e5000 b56f0000 r-xp /usr/lib/libXext.so.6.4.0
b5700000 b5702000 r-xp /usr/lib/libXdamage.so.1.1.0
b5712000 b5714000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5724000 b5806000 r-xp /usr/lib/libX11.so.6.3.0
b581a000 b5821000 r-xp /usr/lib/libXcursor.so.1.0.2
b5831000 b5849000 r-xp /usr/lib/libudev.so.1.6.0
b584b000 b584e000 r-xp /lib/libattr.so.1.1.0
b585e000 b587e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b587f000 b5884000 r-xp /usr/lib/libffi.so.6.0.2
b5895000 b58ad000 r-xp /lib/libz.so.1.2.8
b58bd000 b58bf000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58cf000 b59a4000 r-xp /usr/lib/libxml2.so.2.9.2
b59b9000 b5a54000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a70000 b5a73000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a83000 b5a9c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aad000 b5abe000 r-xp /lib/libresolv-2.20-2014.11.so
b5ad2000 b5b4c000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b61000 b5b63000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b73000 b5b7a000 r-xp /usr/lib/libembryo.so.1.13.0
b5b8a000 b5b94000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5ba5000 b5bbd000 r-xp /usr/lib/libpng12.so.0.50.0
b5bce000 b5bf1000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c12000 b5c26000 r-xp /usr/lib/libector.so.1.13.0
b5c37000 b5c4f000 r-xp /usr/lib/liblua-5.1.so
b5c60000 b5cb7000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ccb000 b5cf3000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d04000 b5d17000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d28000 b5d62000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d73000 b5d81000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d91000 b5d99000 r-xp /usr/lib/libtbm.so.1.0.0
b5da9000 b5db6000 r-xp /usr/lib/libeio.so.1.13.0
b5dc6000 b5dc8000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dd8000 b5ddd000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5ded000 b5e04000 r-xp /usr/lib/libefreet.so.1.13.0
b5e16000 b5e36000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e46000 b5e66000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e68000 b5e6e000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e7e000 b5e8f000 r-xp /usr/lib/libemotion.so.1.13.0
b5ea0000 b5ea7000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eb7000 b5ec6000 r-xp /usr/lib/libeo.so.1.13.0
b5ed7000 b5ee9000 r-xp /usr/lib/libecore_input.so.1.13.0
b5efa000 b5eff000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f0f000 b5f28000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f38000 b5f55000 r-xp /usr/lib/libeet.so.1.13.0
b5f6e000 b5fb6000 r-xp /usr/lib/libeina.so.1.13.0
b5fc7000 b5fd7000 r-xp /usr/lib/libefl.so.1.13.0
b5fe8000 b60cd000 r-xp /usr/lib/libicuuc.so.51.1
b60ea000 b622a000 r-xp /usr/lib/libicui18n.so.51.1
b6241000 b6279000 r-xp /usr/lib/libecore_x.so.1.13.0
b628b000 b628e000 r-xp /lib/libcap.so.2.21
b629e000 b62c7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62d8000 b62df000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62f1000 b6328000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6339000 b6424000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6437000 b64b0000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64c2000 b64c7000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64d7000 b64e1000 r-xp /usr/lib/libvconf.so.0.2.45
b64f1000 b64f3000 r-xp /usr/lib/libvasum.so.0.3.1
b6503000 b6505000 r-xp /usr/lib/libttrace.so.1.1
b6515000 b6518000 r-xp /usr/lib/libiniparser.so.0
b6528000 b654e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b655e000 b6563000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6574000 b658b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b659c000 b6607000 r-xp /lib/libm-2.20-2014.11.so
b6618000 b661e000 r-xp /lib/librt-2.20-2014.11.so
b662f000 b663c000 r-xp /usr/lib/libunwind.so.8.0.1
b6672000 b6796000 r-xp /lib/libc-2.20-2014.11.so
b67ab000 b67c4000 r-xp /lib/libgcc_s-4.9.so.1
b67d4000 b68b6000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68c7000 b68f1000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6902000 b693e000 r-xp /usr/lib/libsystemd.so.0.4.0
b6940000 b69c3000 r-xp /usr/lib/libedje.so.1.13.0
b69d6000 b69f4000 r-xp /usr/lib/libecore.so.1.13.0
b6a14000 b6b9b000 r-xp /usr/lib/libevas.so.1.13.0
b6bd0000 b6be4000 r-xp /lib/libpthread-2.20-2014.11.so
b6bf8000 b6e2c000 r-xp /usr/lib/libelementary.so.1.13.0
b6e5b000 b6e5f000 r-xp /usr/lib/libsmack.so.1.0.0
b6e6f000 b6e76000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e86000 b6e88000 r-xp /usr/lib/libdlog.so.0.0.0
b6e98000 b6e9b000 r-xp /usr/lib/libbundle.so.0.1.22
b6eab000 b6ead000 r-xp /lib/libdl-2.20-2014.11.so
b6ebe000 b6ed6000 r-xp /usr/lib/libaul.so.0.1.0
b6eea000 b6eef000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f00000 b6f0d000 r-xp /usr/lib/liblptcp.so
b6f1f000 b6f23000 r-xp /usr/lib/libsys-assert.so
b6f34000 b6f54000 r-xp /lib/ld-2.20-2014.11.so
b6f65000 b6f6a000 r-xp /usr/bin/launchpad-loader
b849c000 b86c7000 rw-p [heap]
beac1000 beae2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1675)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb669db84) [/lib/libc.so.6] + 0x2bb84
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
) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00009
04-03 03:17:24.858+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-03 03:17:24.868+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-03 03:17:24.988+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(1677) status(0)
04-03 03:17:24.988+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(1677) status(3)
04-03 03:17:24.988+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-03 03:17:24.988+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-03 03:17:24.988+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.tizen.poweroff-syspopup(1677)
04-03 03:17:24.988+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1677, appid: org.tizen.poweroff-syspopup, status: fg
04-03 03:17:24.998+0900 I/APP_CORE( 1677): appcore-efl.c: __do_app(514) > [APP 1677] Event: RESUME State: CREATED
04-03 03:17:25.008+0900 I/APP_CORE( 1677): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-03 03:17:25.008+0900 I/APP_CORE( 1677): appcore-efl.c: __do_app(625) > [APP 1677] Initial Launching, call the resume_cb
04-03 03:17:25.528+0900 I/QUICKPANEL(  856): NotificationItemModel.cpp: __updateSmartAlert(2308) > [0;32mpackage name: popup-launcher, insert: 0[0;m
04-03 03:17:25.528+0900 I/QUICKPANEL(  856): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
04-03 03:17:25.528+0900 W/QUICKPANEL(  856): NotificationItemModel.cpp: removeNotification(297) > [0;35mOngoing notification is deleted.[0;m
04-03 03:17:25.528+0900 I/QUICKPANEL(  856): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
04-03 03:17:25.618+0900 I/CAPI_CONTENT_MEDIA_CONTENT(  873): media_content.c: media_content_disconnect(940) > [32m[873]ref count changed to: 0
04-03 03:17:25.648+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.222
04-03 03:17:25.658+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.tizen.poweroff-syspopup)
04-03 03:17:25.658+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.tizen.poweroff-syspopup, 1677.
04-03 03:17:25.678+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:25.678+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:25.678+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:25.678+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:25.678+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:25.678+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:25.678+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:25.688+0900 E/INDICATOR(  661): ticker.c: _ticker_noti_detailed_changed_cb(1335) > check op_type
04-03 03:17:25.989+0900 W/LOCKSCREEN(  842): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 100 is changed to 0
04-03 03:17:25.989+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:40000:CONF_CHANGED
04-03 03:17:25.989+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:40000 event_info:100
04-03 03:17:25.989+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:100
04-03 03:17:25.999+0900 I/SYNCSERVICE(  979): SyncManager_BatteryStatusListener.cpp: OnBatteryStatusChanged(37) > OnBatteryStatusChanged Starts
04-03 03:17:25.999+0900 I/SYNCSERVICE(  979): SyncManager_SyncManager.cpp: OnBatteryStatusChanged(376) > SyncManager::OnBatteryStatusChanged Starts
04-03 03:17:25.999+0900 I/SYNCSERVICE(  979): SyncManager_SyncManager.cpp: OnBatteryStatusChanged(394) > SyncManager::OnBatteryStatusChanged Ends
04-03 03:17:25.999+0900 I/SYNCSERVICE(  979): SyncManager_BatteryStatusListener.cpp: OnBatteryStatusChanged(43) > OnBatteryStatusChanged Ends
04-03 03:17:25.999+0900 W/LOCKSCREEN(  842): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 800 is changed to 4
04-03 03:17:25.999+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:40000:CONF_CHANGED
04-03 03:17:25.999+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:40000 event_info:800
04-03 03:17:25.999+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:800
04-03 03:17:25.999+0900 I/INDICATOR(  661): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(0) / battery_charging(0)"
04-03 03:17:25.999+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 03:17:25.999+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:25.999+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:25.999+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:25.999+0900 E/RESOURCED(  664): heart-battery.c: heart_battery_calculate_prediction(1096) > No battery capacity history data
04-03 03:17:25.999+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:25.999+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:25.999+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:26.019+0900 I/QUICKPANEL(  856): NotificationItemModel.cpp: __updateSmartAlert(2308) > [0;32mpackage name: popup-launcher, insert: 0[0;m
04-03 03:17:26.019+0900 I/QUICKPANEL(  856): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
04-03 03:17:26.019+0900 W/QUICKPANEL(  856): NotificationItemModel.cpp: removeNotification(297) > [0;35mOngoing notification is deleted.[0;m
04-03 03:17:26.019+0900 E/INDICATOR(  661): ticker.c: _ticker_noti_detailed_changed_cb(1335) > check op_type
04-03 03:17:26.029+0900 I/QUICKPANEL(  856): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
04-03 03:17:26.459+0900 I/UXT     ( 1794): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-03 03:17:26.509+0900 E/TBM     ( 1794): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-03 03:17:26.509+0900 I/MALI    ( 1794): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=1794   open drm_fd=30 
04-03 03:17:26.619+0900 E/EFL     ( 1794): edje<1794> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-03 03:17:26.619+0900 E/EFL     ( 1794): By the power of Grayskull, your previous Embryo stack is now broken!
04-03 03:17:26.619+0900 E/EFL     ( 1794): edje<1794> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-03 03:17:26.619+0900 E/EFL     ( 1794): By the power of Grayskull, your previous Embryo stack is now broken!
04-03 03:17:26.619+0900 E/EFL     ( 1794): edje<1794> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-03 03:17:26.619+0900 E/EFL     ( 1794): By the power of Grayskull, your previous Embryo stack is now broken!
04-03 03:17:26.790+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:26.790+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:26.790+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:26.790+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:26.790+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:26.830+0900 I/AUL     ( 1780): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/popup-launcher, ret : 0
04-03 03:17:26.830+0900 I/AUL     ( 1780): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/dbus-daemon, ret : 0
04-03 03:17:26.840+0900 I/AUL     ( 1780): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/popup-launcher, ret : 0
04-03 03:17:26.850+0900 I/AUL     ( 1780): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/dbus-daemon, ret : 0
04-03 03:17:26.850+0900 E/CAPI_APPFW_APP_MANAGER( 1780): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
04-03 03:17:26.860+0900 I/AUL     (  711): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
04-03 03:17:26.880+0900 I/AUL     (  711): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
04-03 03:17:26.890+0900 I/AUL     (  711): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
04-03 03:17:26.910+0900 I/AUL     (  711): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
04-03 03:17:26.910+0900 E/CAPI_APPFW_APP_MANAGER(  711): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
04-03 03:17:26.950+0900 E/VCONF   (  596): vconf.c: _vconf_check_install_key_list(1135) > key : db/setting/usb_connection_mode
04-03 03:17:26.950+0900 E/VCONF   (  596): vconf.c: _vconf_check_retry_err(1368) > db/setting/usb_connection_mode : check retry err (-21/2).
04-03 03:17:26.950+0900 E/VCONF   (  596): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/setting/usb_connection_mode) step(-21) failed(2 / No such file or directory) retry(0) 
04-03 03:17:26.950+0900 E/VCONF   (  596): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/setting/usb_connection_mode) step(-21) failed(2 / No such file or directory)
04-03 03:17:26.950+0900 E/VCONF   (  596): vconf.c: vconf_get_int(2650) > vconf_get_int(596) : db/setting/usb_connection_mode error
04-03 03:17:26.950+0900 E/VCONF   (  596): vconf-kdb.c: _vconf_kdb_add_notify(329) > _vconf_kdb_add_notify : key(db/usb/sel_mode) has same callback(0xb6eff1ec)
04-03 03:17:26.970+0900 E/QUICKPANEL(  856): NotificationItemModel.cpp: __playSound(1805) > [0;31m* Critical * None type: No sound[0;m
04-03 03:17:26.970+0900 I/QUICKPANEL(  856): NotificationItemModel.cpp: __updateSmartAlert(2308) > [0;32mpackage name: popup-launcher, insert: 1[0;m
04-03 03:17:27.000+0900 E/QUICKPANEL(  856): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
04-03 03:17:27.000+0900 E/QUICKPANEL(  856): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
04-03 03:17:27.000+0900 E/QUICKPANEL(  856): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
04-03 03:17:27.000+0900 E/QUICKPANEL(  856): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
04-03 03:17:27.000+0900 I/QUICKPANEL(  856): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
04-03 03:17:27.000+0900 W/QUICKPANEL(  856): NotificationItemModel.cpp: insertNotification(249) > [0;35mOngoing notification is inserted.[0;m
04-03 03:17:27.000+0900 E/EFL     (  856): eo<856> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (724) could not be resolved for class 'Elm_Layout'.
04-03 03:17:27.000+0900 I/QUICKPANEL(  856): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
04-03 03:17:27.010+0900 E/INDICATOR(  661): ticker.c: _ticker_noti_detailed_changed_cb(1411) > ERROR
04-03 03:17:27.040+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 1808): media_content.c: media_content_connect(856) > [32m[1808]ref count : 0
04-03 03:17:27.050+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 1808): media_content.c: media_content_connect(888) > [32m[1808]ref count changed to: 1
04-03 03:17:27.270+0900 W/LOCKSCREEN(  842): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 400 is changed to 1
04-03 03:17:27.270+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:40000:CONF_CHANGED
04-03 03:17:27.270+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:40000 event_info:400
04-03 03:17:27.270+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:400
04-03 03:17:27.280+0900 I/INDICATOR(  661): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(0) / battery_charging(1)"
04-03 03:17:27.280+0900 W/LOCKSCREEN(  842): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 100 is changed to 1
04-03 03:17:27.280+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:40000:CONF_CHANGED
04-03 03:17:27.280+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:40000 event_info:100
04-03 03:17:27.280+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:100
04-03 03:17:27.280+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 03:17:27.280+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:27.280+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:27.280+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:27.280+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:27.280+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:27.280+0900 E/EFL     ( 1677): ecore_x<1677> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=59222
04-03 03:17:27.290+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-03 03:17:27.310+0900 I/MALI    ( 1677): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=1677   close drm_fd=25 
04-03 03:17:27.320+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-03 03:17:27.330+0900 E/RESOURCED(  664): heart-battery.c: heart_battery_calculate_prediction(1096) > No battery capacity history data
04-03 03:17:27.340+0900 E/RESOURCED(  664): heart-battery.c: heart_battery_calculate_prediction(1055) > No battery capacity history data
04-03 03:17:27.340+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 1677 pgid = 1677
04-03 03:17:27.340+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(1677)
04-03 03:17:27.360+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-03 03:17:27.380+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.tizen.] 
04-03 03:17:27.380+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-03 03:17:27.400+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-03 03:17:27.420+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-03 03:17:27.420+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-03 03:17:27.420+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-03 03:17:27.430+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 1677
04-03 03:17:27.430+0900 I/Tizen::App( 1231): (243) > App[org.tizen.poweroff-syspopup] pid[1677] terminate event is forwarded
04-03 03:17:27.430+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-03 03:17:27.430+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.tizen.poweroff-syspopup, 1677, ]
04-03 03:17:27.430+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-03 03:17:27.430+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.tizen.poweroff-syspopup)
04-03 03:17:27.430+0900 I/Tizen::App( 1231): (512) > Not registered pid(1677)
04-03 03:17:27.430+0900 I/Tizen::System( 1231): (246) > Terminated app [org.tizen.poweroff-syspopup]
04-03 03:17:27.430+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-03 03:17:27.430+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 1677
04-03 03:17:27.430+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 1677
04-03 03:17:27.430+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.227
04-03 03:17:27.480+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-03 03:17:27.480+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.tizen.poweroff-syspopup, 1677.
04-03 03:17:46.229+0900 E/PKGMGR_SERVER( 1882): pkgmgr-server.c: main(2414) > package manager server start
04-03 03:17:46.279+0900 E/PKGMGR  ( 1880): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-03 03:17:46.309+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-03 03:17:46.319+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-03 03:17:46.329+0900 E/PKGMGR_SERVER( 1882): pkgmgr-server.c: sighandler(417) > child NORMAL exit [1885]
04-03 03:17:49.001+0900 E/PKGMGR_SERVER( 1882): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:17:49.001+0900 E/PKGMGR_SERVER( 1882): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:17:50.252+0900 E/PKGMGR  ( 1971): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-03 03:17:50.343+0900 E/PKGMGR_SERVER( 1973): pkgmgr-server.c: main(2414) > package manager server start
04-03 03:17:50.383+0900 E/PKGMGR_SERVER( 1973): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-03 03:17:50.393+0900 E/PKGMGR_SERVER( 1973): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-03 03:17:50.393+0900 E/PKGMGR  ( 1971): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[19710002]
04-03 03:17:50.543+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-03 03:17:50.543+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-03 03:17:50.553+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-03 03:17:50.553+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-03 03:17:50.553+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-03 03:17:50.553+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-03 03:17:50.693+0900 W/CERT_SVC_VCORE( 1976): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-03 03:17:50.753+0900 E/rpm-installer( 1976): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-03 03:17:50.753+0900 E/rpm-installer( 1976): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-03 03:17:50.813+0900 E/PKGMGR_PARSER( 1976): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-03 03:17:50.833+0900 I/PRIVACY-MANAGER-CLIENT( 1976): SocketClient.cpp: SocketClient(37) > Client created
04-03 03:17:50.833+0900 I/PRIVACY-MANAGER-CLIENT( 1976): SocketClient.cpp: connect(62) > Client connected
04-03 03:17:50.833+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-03 03:17:50.833+0900 I/PRIVACY-MANAGER-CLIENT( 1976): SocketClient.cpp: disconnect(72) > Client disconnected
04-03 03:17:50.833+0900 E/PKGMGR_CERT( 1976): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-03 03:17:50.843+0900 E/PKGMGR_CERT( 1976): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-03 03:17:50.843+0900 E/PKGMGR_CERT( 1976): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-03 03:17:50.873+0900 E/rpm-installer( 1976): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-03 03:17:50.883+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-03 03:17:50.883+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-03 03:17:50.883+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-03 03:17:50.883+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-03 03:17:50.893+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-03 03:17:50.893+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-03 03:17:52.535+0900 E/PKGMGR_SERVER( 1973): pkgmgr-server.c: sighandler(417) > child NORMAL exit [1976]
04-03 03:17:53.005+0900 E/PKGMGR_SERVER( 1973): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:17:53.005+0900 E/PKGMGR_SERVER( 1973): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:17:53.756+0900 E/PKGMGR  ( 2024): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-03 03:17:53.836+0900 E/PKGMGR_SERVER( 2026): pkgmgr-server.c: main(2414) > package manager server start
04-03 03:17:53.886+0900 E/PKGMGR_SERVER( 2026): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-03 03:17:53.896+0900 E/PKGMGR_INFO( 2026): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-03 03:17:53.906+0900 E/rpm-installer( 2026): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-03 03:17:53.906+0900 E/PKGMGR_SERVER( 2026): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-03 03:17:53.916+0900 E/PKGMGR  ( 2024): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[20240002]
04-03 03:17:54.026+0900 E/PKGMGR_INSTALLER( 2029): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-03 03:17:54.026+0900 E/rpm-installer( 2029): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-03 03:17:54.036+0900 E/rpm-installer( 2029): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-03 03:17:54.036+0900 E/rpm-installer( 2029): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-03 03:17:54.036+0900 E/rpm-installer( 2029): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-03 03:17:54.036+0900 E/rpm-installer( 2029): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-03 03:17:54.036+0900 E/rpm-installer( 2029): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-03 03:17:54.086+0900 W/CERT_SVC_VCORE( 2029): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-03 03:17:54.136+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-03 03:17:54.136+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-03 03:17:54.136+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-03 03:17:54.136+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-03 03:17:54.136+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-03 03:17:54.306+0900 E/rpm-installer( 2029): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-03 03:17:54.306+0900 E/rpm-installer( 2029): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-03 03:17:54.306+0900 E/rpm-installer( 2029): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-03 03:17:54.306+0900 E/rpm-installer( 2029): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-03 03:17:54.316+0900 E/rpm-installer( 2029): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-03 03:17:54.316+0900 E/rpm-installer( 2029): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-03 03:17:54.316+0900 E/PKGMGR_PARSER( 2029): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-03 03:17:54.326+0900 E/PKGMGR_PARSER( 2029): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-03 03:17:54.356+0900 I/PRIVACY-MANAGER-CLIENT( 2029): SocketClient.cpp: SocketClient(37) > Client created
04-03 03:17:54.567+0900 E/PKGMGR_PARSER( 2029): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-03 03:17:54.587+0900 E/PKGMGR_CERT( 2029): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-03 03:17:54.587+0900 E/PKGMGR_CERT( 2029): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 108
04-03 03:17:54.587+0900 E/PKGMGR_CERT( 2029): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 108
04-03 03:17:54.587+0900 E/PKGMGR_CERT( 2029): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
04-03 03:17:54.587+0900 E/PKGMGR_CERT( 2029): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 3
04-03 03:17:54.587+0900 E/PKGMGR_CERT( 2029): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 3
04-03 03:17:54.587+0900 E/PKGMGR_CERT( 2029): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
04-03 03:17:54.597+0900 E/PKGMGR_CERT( 2029): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-03 03:17:54.597+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-03 03:17:54.597+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-03 03:17:54.597+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-03 03:17:54.617+0900 E/rpm-installer( 2029): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-03 03:17:54.637+0900 E/rpm-installer( 2029): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-03 03:17:54.637+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-03 03:17:54.637+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-03 03:17:54.637+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-03 03:17:55.998+0900 E/PKGMGR_SERVER( 2026): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-03 03:17:56.509+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-03 03:17:56.509+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-03 03:17:56.509+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-03 03:17:56.509+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-03 03:17:56.509+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-03 03:17:56.509+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-03 03:17:56.569+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-03 03:17:56.579+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-03 03:17:56.589+0900 E/PKGMGR_SERVER( 2026): pkgmgr-server.c: sighandler(417) > child NORMAL exit [2029]
04-03 03:17:56.599+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-03 03:17:56.609+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-03 03:17:56.609+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 03:17:56.609+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-03 03:17:56.609+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-03 03:17:56.609+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-03 03:17:56.609+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-03 03:17:56.609+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-03 03:17:56.609+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-03 03:17:56.609+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-03 03:17:56.609+0900 I/Tizen::App( 1231): (840) > Enter.
04-03 03:17:56.619+0900 I/Tizen::App( 1231): (703) > Exit.
04-03 03:17:56.619+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-03 03:17:56.619+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-03 03:17:56.619+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 03:17:56.619+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-03 03:17:56.619+0900 I/Tizen::App( 1231): (131) > Enter
04-03 03:17:56.629+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-03 03:17:56.629+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-03 03:17:56.629+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-03 03:17:56.629+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-03 03:17:56.629+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-03 03:17:56.629+0900 I/Tizen::App( 1231): (883) > Exit.
04-03 03:17:56.649+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-03 03:17:56.659+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-03 03:17:58.000+0900 E/PKGMGR_SERVER( 2026): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:17:58.000+0900 E/PKGMGR_SERVER( 2026): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:17:58.320+0900 W/LOCKSCREEN(  842): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 400 is changed to 0
04-03 03:17:58.320+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:40000:CONF_CHANGED
04-03 03:17:58.320+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:40000 event_info:400
04-03 03:17:58.320+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:400
04-03 03:17:58.320+0900 W/LOCKSCREEN(  842): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 800 is changed to 5
04-03 03:17:58.320+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:40000:CONF_CHANGED
04-03 03:17:58.320+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:40000 event_info:800
04-03 03:17:58.320+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:800
04-03 03:17:58.330+0900 I/SYNCSERVICE(  979): SyncManager_BatteryStatusListener.cpp: OnBatteryStatusChanged(37) > OnBatteryStatusChanged Starts
04-03 03:17:58.330+0900 I/SYNCSERVICE(  979): SyncManager_SyncManager.cpp: OnBatteryStatusChanged(376) > SyncManager::OnBatteryStatusChanged Starts
04-03 03:17:58.330+0900 I/SYNCSERVICE(  979): SyncManager_SyncManager.cpp: OnBatteryStatusChanged(394) > SyncManager::OnBatteryStatusChanged Ends
04-03 03:17:58.330+0900 I/SYNCSERVICE(  979): SyncManager_BatteryStatusListener.cpp: OnBatteryStatusChanged(43) > OnBatteryStatusChanged Ends
04-03 03:17:58.390+0900 I/INDICATOR(  661): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(0) / battery_charging(0)"
04-03 03:17:58.390+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 03:17:58.390+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:58.390+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:58.390+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:58.390+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:58.390+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:58.390+0900 I/INDICATOR(  661): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(1) / battery_charging(0)"
04-03 03:17:58.390+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 03:17:58.390+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:58.390+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:58.390+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:17:58.430+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:58.430+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:17:58.581+0900 I/AUL     ( 2037): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/popup-launcher, ret : 0
04-03 03:17:58.591+0900 I/AUL     ( 2037): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/dbus-daemon, ret : 0
04-03 03:17:58.601+0900 I/AUL     ( 2037): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/popup-launcher, ret : 0
04-03 03:17:58.611+0900 I/AUL     ( 2037): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/dbus-daemon, ret : 0
04-03 03:17:58.611+0900 E/CAPI_APPFW_APP_MANAGER( 2037): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
04-03 03:17:58.621+0900 I/AUL     (  711): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
04-03 03:17:58.631+0900 I/AUL     (  711): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
04-03 03:17:58.641+0900 I/AUL     (  711): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
04-03 03:17:58.641+0900 I/AUL     (  711): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/data-provider-master, ret : 0
04-03 03:17:58.641+0900 E/CAPI_APPFW_APP_MANAGER(  711): app_manager.c: app_manager_error(74) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
04-03 03:17:58.691+0900 E/QUICKPANEL(  856): NotificationItemModel.cpp: __playSound(1805) > [0;31m* Critical * None type: No sound[0;m
04-03 03:17:58.691+0900 I/QUICKPANEL(  856): NotificationItemModel.cpp: __updateSmartAlert(2308) > [0;32mpackage name: popup-launcher, insert: 1[0;m
04-03 03:17:58.701+0900 E/INDICATOR(  661): ticker.c: _ticker_noti_detailed_changed_cb(1411) > ERROR
04-03 03:17:58.701+0900 E/QUICKPANEL(  856): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
04-03 03:17:58.701+0900 E/QUICKPANEL(  856): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
04-03 03:17:58.711+0900 E/QUICKPANEL(  856): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
04-03 03:17:58.711+0900 E/QUICKPANEL(  856): NotificationItemControl.cpp: __isIconAnimated(670) > [0;31m* Critical * object doesn't exist.[0;m
04-03 03:17:58.711+0900 I/QUICKPANEL(  856): ScrollContainerViManager.cpp: startAnimation(74) > [0;32mAnimation is started.[0;m
04-03 03:17:58.711+0900 W/QUICKPANEL(  856): NotificationItemModel.cpp: insertNotification(249) > [0;35mOngoing notification is inserted.[0;m
04-03 03:17:58.711+0900 E/EFL     (  856): eo<856> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (724) could not be resolved for class 'Elm_Layout'.
04-03 03:17:58.711+0900 I/QUICKPANEL(  856): ScrollContainerViManager.cpp: __onAnimationFinished(465) > [0;32mAnimation is finished.[0;m
04-03 03:17:58.931+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1402): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(719) > [0;35m* Info * Lets check ongoing request....[0;m
04-03 03:17:58.931+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1402): cs_server_task_manager.c: __release_power_lock(668) > [0;35m* Info * No Ongoing Task[0;m
04-03 03:17:58.931+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1402): cs_server_task_manager.c: __release_power_lock(670) > [0;35m* Info * power lock is already released![0;m
04-03 03:17:58.931+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1402): cs_server_main.c: ___g_destroy_timer_expire_cb(179) > [0;35m* Info * Destory Cloud content sync as there is no task ongoing....[0;m
04-03 03:17:58.931+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1402): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(610) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
04-03 03:17:58.931+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1402): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(610) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
04-03 03:17:58.931+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1402): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(610) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
04-03 03:17:58.931+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1402): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(610) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
04-03 03:17:58.931+0900 E/CLOUD_CONTENT_SYNC_COMMON( 1402): cs_common.c: _common_get_hash_table_size(165) > [0;31m* Critical * Invalid params[0;m
04-03 03:17:58.931+0900 E/CLOUD_CONTENT_SYNC_SERVER( 1402): cs_server_notification_manager.c: _server_noti_manager_destroy(1722) > [0;31m* Critical * invalid req_thread[0;m
04-03 03:17:58.931+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1402): cs_server_main.c: _cloud_content_sync_deactivate(166) > [0;35m* Info * exiting cloud-content-sync-server[0;m
04-03 03:17:58.931+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1402): cs_server_main.c: __init_cloud_content_sync(334) > [0;35m* Info * -------------------- Exit cloud server ------------------[0;m
04-03 03:17:58.941+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1402): cs_server_task_manager.c: __event_handler(324) > [0;35m* Info * Dummy Request - break from loop [0;m
04-03 03:17:58.941+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 1402): media_content.c: media_content_disconnect(940) > [32m[1402]ref count changed to: 0
04-03 03:17:58.941+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1402): cs_server_dispatch_manager.c: _server_dispatch_manager_deinit(531) > [0;35m* Info * wait at join[0;m
04-03 03:17:58.941+0900 I/CLOUD_CONTENT_SYNC_TRANS( 1402): cs_transport_async_req_handler.c: __event_handler(112) > [0;35m* Info * Dummy Request - break from loop [0;m
04-03 03:17:58.941+0900 I/CAPI_NETWORK_CONNECTION( 1402): connection.c: connection_destroy(427) > Destroy handle: 0xb7412f10
04-03 03:17:58.941+0900 I/CAPI_NETWORK_CONNECTION( 1402): connection.c: __connection_set_type_changed_callback(181) > Successfully de-registered(0)
04-03 03:17:58.941+0900 I/CAPI_NETWORK_CONNECTION( 1402): connection.c: __connection_set_proxy_changed_callback(351) > Successfully de-registered(0)
04-03 03:17:58.961+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-03 03:17:58.961+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 7
04-03 03:17:58.961+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-03 03:17:58.961+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-03 03:17:59.221+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
04-03 03:17:59.231+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 1402
04-03 03:17:59.231+0900 I/Tizen::App( 1231): (243) > App[com.samsung.cloud-content-sync] pid[1402] terminate event is forwarded
04-03 03:17:59.231+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-03 03:17:59.231+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [com.samsung.cloud-content-sync, 1402, ]
04-03 03:17:59.231+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-03 03:17:59.231+0900 I/Tizen::App( 1231): (506) > TerminatedApp(com.samsung.cloud-content-sync)
04-03 03:17:59.231+0900 I/Tizen::App( 1231): (512) > Not registered pid(1402)
04-03 03:17:59.231+0900 I/Tizen::System( 1231): (246) > Terminated app [com.samsung.cloud-content-sync]
04-03 03:17:59.231+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-03 03:17:59.231+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 1402
04-03 03:17:59.231+0900 E/AUL_AMD (  610): amd_launch.c: _amd_proc_remove_proc_info(1947) > proc info not found
04-03 03:17:59.231+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-03 03:17:59.231+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync, 1402.
04-03 03:18:00.022+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-03 03:18:00.032+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:18
04-03 03:18:00.032+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:18"
04-03 03:18:00.032+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:18"
04-03 03:18:00.032+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-03 03:18:00.032+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147034770 Time: <font_size=31> </font_size> <font_size=31> 오전 3:18</font_size></font>"
04-03 03:18:00.723+0900 W/AUL     ( 2089): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-03 03:18:00.723+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-03 03:18:00.733+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-03 03:18:00.743+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-03 03:18:00.743+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-03 03:18:00.743+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 2089
04-03 03:18:00.743+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-03 03:18:00.753+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-03 03:18:00.753+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-03 03:18:00.753+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-03 03:18:00.753+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-03 03:18:00.753+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-03 03:18:00.773+0900 I/abc     ( 1675): abc
04-03 03:18:00.773+0900 I/CAPI_APPFW_APPLICATION( 1675): app_main.c: ui_app_main(789) > app_efl_main
04-03 03:18:00.773+0900 I/CAPI_APPFW_APPLICATION( 1675): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-03 03:18:00.803+0900 E/TBM     ( 1675): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-03 03:18:00.853+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 1675, appid: org.example.client
04-03 03:18:00.853+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-03 03:18:00.873+0900 W/AUL     ( 2089): launch.c: app_request_to_launchpad(425) > request cmd(0) result(1675)
04-03 03:18:00.873+0900 E/RESOURCED(  664): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.client
04-03 03:18:01.043+0900 W/CRASH_MANAGER( 2099): worker.c: worker_job(1199) > 0601675636c69149115708
