S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 4140
Date: 2017-04-06 16:48:37+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 4140, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x0000102c
r2   = 0x00000006, r3   = 0xb409f4c0
r4   = 0x00000002, r5   = 0xb409f000
r6   = 0xb679909c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5ec7708
r10  = 0xb8a53c30, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbeb21c1c
lr   = 0xb668ff18, pc   = 0xb668eb84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    168708 KB
Buffers:     46564 KB
Cached:     322344 KB
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
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4140 TID = 4140
4140 4141 7473 7478 7482 

Maps Information
aee4c000 af64b000 rw-p [stack:7482]
b0f44000 b0f55000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f65000 b0f6a000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b136c000 b1374000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1386000 b1b85000 rw-p [stack:7478]
b1b85000 b1b86000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b96000 b1baa000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bbe000 b1bbf000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bcf000 b1bd2000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1be3000 b1be4000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bf4000 b1bf6000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c06000 b1c08000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c18000 b1c28000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c38000 b1c44000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c56000 b2455000 rw-p [stack:7473]
b2786000 b278d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27a0000 b27a6000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27b6000 b27d2000 r-xp /opt/usr/apps/org.example.client/bin/client
b292b000 b2a0e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a45000 b2a6d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a7f000 b327e000 rw-p [stack:4141]
b327e000 b3280000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3290000 b329a000 r-xp /lib/libnss_files-2.20-2014.11.so
b32ab000 b32b4000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32c5000 b32d6000 r-xp /lib/libnsl-2.20-2014.11.so
b32e9000 b32ef000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3300000 b3301000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3329000 b3330000 r-xp /usr/lib/libminizip.so.1.0.0
b3340000 b3345000 r-xp /usr/lib/libstorage.so.0.1
b3355000 b33b4000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33ca000 b33de000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33ee000 b3432000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3442000 b344a000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b345a000 b348a000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b349d000 b3556000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b356a000 b35bd000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35ce000 b35e9000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35f9000 b36ba000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36cd000 b36dd000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36ed000 b36fa000 r-xp /usr/lib/libmdm-common.so.1.0.98
b370b000 b3712000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3722000 b3763000 r-xp /usr/lib/libmdm.so.1.2.12
b3773000 b377b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b378a000 b379a000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37bb000 b381b000 r-xp /usr/lib/libasound.so.2.0.0
b382d000 b3830000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3840000 b3843000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3853000 b3858000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3868000 b3869000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3879000 b3884000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3898000 b389f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38af000 b38b5000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38c5000 b38ca000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38da000 b38f5000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3905000 b390c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b391c000 b391f000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3930000 b395e000 r-xp /usr/lib/libidn.so.11.5.44
b396e000 b3984000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3995000 b399f000 r-xp /usr/lib/libcares.so.2.1.0
b39af000 b39b9000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39c9000 b39cb000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39db000 b39dc000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39ec000 b39f0000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a01000 b3a29000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a3a000 b3a63000 r-xp /usr/lib/libturbojpeg.so
b3a83000 b3a89000 r-xp /usr/lib/libgif.so.4.1.6
b3a99000 b3adf000 r-xp /usr/lib/libcurl.so.4.3.0
b3af0000 b3b11000 r-xp /usr/lib/libexif.so.12.3.3
b3b2c000 b3b41000 r-xp /usr/lib/libtts.so
b3b52000 b3b5a000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b6a000 b3c30000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c50000 b3d48000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d67000 b3e35000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e4c000 b3e4e000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e5e000 b3e64000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e74000 b3e97000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ea8000 b3eaa000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eba000 b3ebc000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ecd000 b3ed2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ee9000 b3eeb000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3efb000 b3f02000 r-xp /usr/lib/libsensord-share.so
b3f12000 b3f2a000 r-xp /usr/lib/libsensor.so.1.1.0
b3f3b000 b3f3e000 r-xp /usr/lib/libXv.so.1.0.0
b3f4e000 b3f53000 r-xp /usr/lib/libutilX.so.1.1.0
b3f63000 b3f68000 r-xp /usr/lib/libappcore-common.so.1.1
b3f78000 b3f7f000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f92000 b3f96000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fa7000 b4085000 r-xp /usr/lib/libCOREGL.so.4.0
b40a5000 b40a8000 r-xp /usr/lib/libuuid.so.1.3.0
b40b8000 b40cf000 r-xp /usr/lib/libblkid.so.1.1.0
b40e0000 b40e2000 r-xp /usr/lib/libXau.so.6.0.0
b40f2000 b4139000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b414b000 b4151000 r-xp /usr/lib/libjson-c.so.2.0.1
b4162000 b4166000 r-xp /usr/lib/libogg.so.0.7.1
b4176000 b4198000 r-xp /usr/lib/libvorbis.so.0.4.3
b41a8000 b428c000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42a8000 b42ab000 r-xp /usr/lib/libEGL.so.1.4
b42bc000 b42c2000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42d2000 b42d4000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42e4000 b42f1000 r-xp /usr/lib/libGLESv2.so.2.0
b4302000 b4364000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4379000 b4391000 r-xp /usr/lib/libmount.so.1.1.0
b43a3000 b43b7000 r-xp /usr/lib/libxcb.so.1.1.0
b43c7000 b43ce000 r-xp /lib/libcrypt-2.20-2014.11.so
b4406000 b4408000 r-xp /usr/lib/libiri.so
b4418000 b4423000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4434000 b446a000 r-xp /usr/lib/libpulse.so.0.16.2
b447b000 b44be000 r-xp /usr/lib/libsndfile.so.1.0.25
b44d3000 b44e8000 r-xp /lib/libexpat.so.1.5.2
b44fa000 b45b8000 r-xp /usr/lib/libcairo.so.2.11200.14
b45cc000 b45d4000 r-xp /usr/lib/libdrm.so.2.4.0
b45e4000 b45e7000 r-xp /usr/lib/libdri2.so.0.0.0
b45f7000 b4645000 r-xp /usr/lib/libssl.so.1.0.0
b465a000 b4666000 r-xp /usr/lib/libeeze.so.1.13.0
b4677000 b4680000 r-xp /usr/lib/libethumb.so.1.13.0
b4690000 b4693000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46a3000 b485a000 r-xp /usr/lib/libcrypto.so.1.0.0
b5645000 b564e000 r-xp /usr/lib/libXi.so.6.1.0
b565e000 b5660000 r-xp /usr/lib/libXgesture.so.7.0.0
b5670000 b5674000 r-xp /usr/lib/libXtst.so.6.1.0
b5684000 b568a000 r-xp /usr/lib/libXrender.so.1.3.0
b569a000 b56a0000 r-xp /usr/lib/libXrandr.so.2.2.0
b56b0000 b56b2000 r-xp /usr/lib/libXinerama.so.1.0.0
b56c3000 b56c6000 r-xp /usr/lib/libXfixes.so.3.1.0
b56d6000 b56e1000 r-xp /usr/lib/libXext.so.6.4.0
b56f1000 b56f3000 r-xp /usr/lib/libXdamage.so.1.1.0
b5703000 b5705000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5715000 b57f7000 r-xp /usr/lib/libX11.so.6.3.0
b580b000 b5812000 r-xp /usr/lib/libXcursor.so.1.0.2
b5822000 b583a000 r-xp /usr/lib/libudev.so.1.6.0
b583c000 b583f000 r-xp /lib/libattr.so.1.1.0
b584f000 b586f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5870000 b5875000 r-xp /usr/lib/libffi.so.6.0.2
b5886000 b589e000 r-xp /lib/libz.so.1.2.8
b58ae000 b58b0000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58c0000 b5995000 r-xp /usr/lib/libxml2.so.2.9.2
b59aa000 b5a45000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a61000 b5a64000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a74000 b5a8d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a9e000 b5aaf000 r-xp /lib/libresolv-2.20-2014.11.so
b5ac3000 b5b3d000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b52000 b5b54000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b64000 b5b6b000 r-xp /usr/lib/libembryo.so.1.13.0
b5b7b000 b5b85000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b96000 b5bae000 r-xp /usr/lib/libpng12.so.0.50.0
b5bbf000 b5be2000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c03000 b5c17000 r-xp /usr/lib/libector.so.1.13.0
b5c28000 b5c40000 r-xp /usr/lib/liblua-5.1.so
b5c51000 b5ca8000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cbc000 b5ce4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cf5000 b5d08000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d19000 b5d53000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d64000 b5d72000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d82000 b5d8a000 r-xp /usr/lib/libtbm.so.1.0.0
b5d9a000 b5da7000 r-xp /usr/lib/libeio.so.1.13.0
b5db7000 b5db9000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dc9000 b5dce000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dde000 b5df5000 r-xp /usr/lib/libefreet.so.1.13.0
b5e07000 b5e27000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e37000 b5e57000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e59000 b5e5f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e6f000 b5e80000 r-xp /usr/lib/libemotion.so.1.13.0
b5e91000 b5e98000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ea8000 b5eb7000 r-xp /usr/lib/libeo.so.1.13.0
b5ec8000 b5eda000 r-xp /usr/lib/libecore_input.so.1.13.0
b5eeb000 b5ef0000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f00000 b5f19000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f29000 b5f46000 r-xp /usr/lib/libeet.so.1.13.0
b5f5f000 b5fa7000 r-xp /usr/lib/libeina.so.1.13.0
b5fb8000 b5fc8000 r-xp /usr/lib/libefl.so.1.13.0
b5fd9000 b60be000 r-xp /usr/lib/libicuuc.so.51.1
b60db000 b621b000 r-xp /usr/lib/libicui18n.so.51.1
b6232000 b626a000 r-xp /usr/lib/libecore_x.so.1.13.0
b627c000 b627f000 r-xp /lib/libcap.so.2.21
b628f000 b62b8000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62c9000 b62d0000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62e2000 b6319000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b632a000 b6415000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6428000 b64a1000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64b3000 b64b8000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64c8000 b64d2000 r-xp /usr/lib/libvconf.so.0.2.45
b64e2000 b64e4000 r-xp /usr/lib/libvasum.so.0.3.1
b64f4000 b64f6000 r-xp /usr/lib/libttrace.so.1.1
b6506000 b6509000 r-xp /usr/lib/libiniparser.so.0
b6519000 b653f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b654f000 b6554000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6565000 b657c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b658d000 b65f8000 r-xp /lib/libm-2.20-2014.11.so
b6609000 b660f000 r-xp /lib/librt-2.20-2014.11.so
b6620000 b662d000 r-xp /usr/lib/libunwind.so.8.0.1
b6663000 b6787000 r-xp /lib/libc-2.20-2014.11.so
b679c000 b67b5000 r-xp /lib/libgcc_s-4.9.so.1
b67c5000 b68a7000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68b8000 b68e2000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68f3000 b692f000 r-xp /usr/lib/libsystemd.so.0.4.0
b6931000 b69b4000 r-xp /usr/lib/libedje.so.1.13.0
b69c7000 b69e5000 r-xp /usr/lib/libecore.so.1.13.0
b6a05000 b6b8c000 r-xp /usr/lib/libevas.so.1.13.0
b6bc1000 b6bd5000 r-xp /lib/libpthread-2.20-2014.11.so
b6be9000 b6e1d000 r-xp /usr/lib/libelementary.so.1.13.0
b6e4c000 b6e50000 r-xp /usr/lib/libsmack.so.1.0.0
b6e60000 b6e67000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e77000 b6e79000 r-xp /usr/lib/libdlog.so.0.0.0
b6e89000 b6e8c000 r-xp /usr/lib/libbundle.so.0.1.22
b6e9c000 b6e9e000 r-xp /lib/libdl-2.20-2014.11.so
b6eaf000 b6ec7000 r-xp /usr/lib/libaul.so.0.1.0
b6edb000 b6ee0000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ef1000 b6efe000 r-xp /usr/lib/liblptcp.so
b6f10000 b6f14000 r-xp /usr/lib/libsys-assert.so
b6f25000 b6f45000 r-xp /lib/ld-2.20-2014.11.so
b6f56000 b6f5b000 r-xp /usr/bin/launchpad-loader
b86d0000 b8aaf000 rw-p [heap]
beb02000 beb23000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4140)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb668eb84) [/lib/libc.so.6] + 0x2bb84
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
quest_handler(906) > __request_handler: 14
04-06 16:48:19.130+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:19.230+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:19.230+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:19.340+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:19.340+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:19.440+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:19.440+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:19.541+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:19.541+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:19.641+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:19.641+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:19.741+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:19.741+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:19.841+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:19.841+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:19.941+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:19.941+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:20.041+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:20.041+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:20.141+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:20.141+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:20.241+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:20.241+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:20.341+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:20.341+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:20.441+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:20.441+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:20.541+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:20.541+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:20.642+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:20.642+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:20.742+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:20.742+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:20.852+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:20.852+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:20.952+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:20.952+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:21.052+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:21.052+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:21.152+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:21.152+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:21.252+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:21.252+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:21.352+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:21.352+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:21.452+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:21.452+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:21.552+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:21.552+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:21.653+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:21.653+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:21.753+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:21.753+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:21.853+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:21.853+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:21.953+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:21.953+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:22.053+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:22.053+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:22.153+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:22.153+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:22.263+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:22.263+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:22.363+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:22.363+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:22.463+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:22.463+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:22.563+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:22.563+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:22.664+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3721)
04-06 16:48:22.664+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 16:48:22.664+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(3721) is dead. cmd(5) is canceled
04-06 16:48:22.664+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 16:48:22.664+0900 E/PKGMGR_SERVER( 7270): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 16:48:22.664+0900 E/PKGMGR_SERVER( 7270): [0;m
04-06 16:48:22.664+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3857)
04-06 16:48:22.664+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 16:48:22.664+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(3857) is dead. cmd(5) is canceled
04-06 16:48:22.664+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 16:48:22.664+0900 E/PKGMGR_SERVER( 7270): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 16:48:22.664+0900 E/PKGMGR_SERVER( 7270): [0;m
04-06 16:48:22.664+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(396) > request cmd(5) to(4286)
04-06 16:48:22.664+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 16:48:22.664+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(4286) is dead. cmd(5) is canceled
04-06 16:48:22.664+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 16:48:22.664+0900 E/PKGMGR_SERVER( 7270): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 16:48:22.664+0900 E/PKGMGR_SERVER( 7270): [0;m
04-06 16:48:22.664+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5436)
04-06 16:48:22.664+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 16:48:22.664+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(5436) is dead. cmd(5) is canceled
04-06 16:48:22.664+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 16:48:22.664+0900 E/PKGMGR_SERVER( 7270): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 16:48:22.664+0900 E/PKGMGR_SERVER( 7270): [0;m
04-06 16:48:22.664+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5598)
04-06 16:48:22.664+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 16:48:22.664+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(5598) is dead. cmd(5) is canceled
04-06 16:48:22.664+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 16:48:22.664+0900 E/PKGMGR_SERVER( 7270): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 16:48:22.664+0900 E/PKGMGR_SERVER( 7270): [0;m
04-06 16:48:22.664+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5718)
04-06 16:48:22.664+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 16:48:22.664+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(5718) is dead. cmd(5) is canceled
04-06 16:48:22.664+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-06 16:48:22.664+0900 E/PKGMGR_SERVER( 7270): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-06 16:48:22.664+0900 E/PKGMGR_SERVER( 7270): [0;m
04-06 16:48:22.664+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5869)
04-06 16:48:22.664+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-06 16:48:22.674+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(5869), cmd(4)
04-06 16:48:22.674+0900 W/AUL     ( 7270): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
04-06 16:48:22.674+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:22.674+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5869
04-06 16:48:22.674+0900 I/APP_CORE( 5869): appcore-efl.c: __do_app(514) > [APP 5869] Event: TERMINATE State: RUNNING
04-06 16:48:22.674+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 16:48:22.674+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 16:48:22.674+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 16:48:22.674+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 16:48:22.684+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 5869): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 10
04-06 16:48:22.684+0900 E/APP_CORE( 5869): appcore-efl.c: _capture_and_make_file(1619) > win[6800002] widget[720] height[1280]
04-06 16:48:22.684+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-06 16:48:22.684+0900 E/APP_CORE( 5869): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-06 16:48:22.684+0900 I/CAPI_APPFW_APPLICATION( 5869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 16:48:22.684+0900 I/CAPI_APPFW_APPLICATION( 5869): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-06 16:48:22.694+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 16:48:22.704+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(3)
04-06 16:48:22.704+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 16:48:22.704+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 16:48:22.704+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(869)
04-06 16:48:22.704+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: fg
04-06 16:48:22.724+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(0)
04-06 16:48:22.764+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: RESUME State: PAUSED
04-06 16:48:22.764+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 16:48:22.764+0900 E/cluster-home(  869): homescreen.cpp: OnResume(233) >  app resume
04-06 16:48:22.764+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 16:48:22.774+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 16:48:22.774+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-06 16:48:22.794+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 16:48:22.794+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 16:48:22.794+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: fg
04-06 16:48:22.804+0900 E/PKGMGR_SERVER( 7267): pkgmgr-server.c: sighandler(417) > child NORMAL exit [7270]
04-06 16:48:22.804+0900 E/PKGMGR_SERVER( 7267): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 16:48:22.824+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [org.exampl] 
04-06 16:48:22.824+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 16:48:22.824+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:22.834+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:22.834+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 16:48:22.854+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 16:48:22.854+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 16:48:22.854+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 16:48:22.854+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 16:48:22.864+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 16:48:23.144+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-06 16:48:23.144+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-06 16:48:23.164+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-06 16:48:23.164+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 16:48:23.164+0900 I/Tizen::App( 1248): (119) > InstallationInProgress [30]
04-06 16:48:23.164+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-06 16:48:23.374+0900 W/CERT_SVC_VCORE( 7358): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 16:48:23.464+0900 E/rpm-installer( 7358): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-06 16:48:23.464+0900 E/rpm-installer( 7358): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-06 16:48:23.554+0900 E/PKGMGR_PARSER( 7358): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-06 16:48:23.584+0900 I/PRIVACY-MANAGER-CLIENT( 7358): SocketClient.cpp: SocketClient(37) > Client created
04-06 16:48:23.584+0900 I/PRIVACY-MANAGER-CLIENT( 7358): SocketClient.cpp: connect(62) > Client connected
04-06 16:48:23.584+0900 I/PRIVACY-MANAGER-SERVER(  922): SocketService.cpp: mainloop(230) > Got incoming connection
04-06 16:48:23.584+0900 I/PRIVACY-MANAGER-CLIENT( 7358): SocketClient.cpp: disconnect(72) > Client disconnected
04-06 16:48:23.594+0900 E/PKGMGR_CERT( 7358): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-06 16:48:23.594+0900 E/PKGMGR_CERT( 7358): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-06 16:48:23.604+0900 E/PKGMGR_CERT( 7358): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-06 16:48:23.665+0900 E/rpm-installer( 7358): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-06 16:48:23.665+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-06 16:48:23.665+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-06 16:48:23.665+0900 E/ESD     (  901): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-06 16:48:23.675+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-06 16:48:23.675+0900 W/ISF_PANEL_EFL(  774): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-06 16:48:23.675+0900 W/ISF_PANEL_EFL(  774): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-06 16:48:23.805+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:23.815+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:23.825+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:23.835+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:23.845+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:23.855+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:23.865+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:23.865+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:23.885+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:23.885+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:23.905+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:23.905+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:23.925+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:23.925+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:23.945+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:23.945+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:23.965+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:23.965+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:23.965+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:23.965+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:23.985+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:23.985+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:23.995+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:24.005+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:24.015+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:24.025+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:24.896+0900 E/PKGMGR_SERVER( 7267): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 16:48:25.536+0900 E/PKGMGR_SERVER( 7267): pkgmgr-server.c: sighandler(417) > child NORMAL exit [7358]
04-06 16:48:26.147+0900 E/PKGMGR  ( 7407): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-06 16:48:26.177+0900 E/PKGMGR_SERVER( 7267): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-06 16:48:26.187+0900 E/PKGMGR_INFO( 7267): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-06 16:48:26.197+0900 E/rpm-installer( 7267): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-06 16:48:26.197+0900 E/PKGMGR_SERVER( 7267): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-06 16:48:26.207+0900 E/PKGMGR  ( 7407): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[74070002]
04-06 16:48:26.317+0900 E/PKGMGR_INSTALLER( 7409): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-06 16:48:26.317+0900 E/rpm-installer( 7409): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-06 16:48:26.337+0900 E/rpm-installer( 7409): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-06 16:48:26.337+0900 E/rpm-installer( 7409): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-06 16:48:26.337+0900 E/rpm-installer( 7409): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 16:48:26.337+0900 E/rpm-installer( 7409): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-06 16:48:26.337+0900 E/rpm-installer( 7409): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 16:48:26.397+0900 W/CERT_SVC_VCORE( 7409): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 16:48:26.447+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-06 16:48:26.447+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-06 16:48:26.457+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 16:48:26.457+0900 I/Tizen::App( 1248): (119) > InstallationInProgress [30]
04-06 16:48:26.457+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-06 16:48:26.687+0900 E/rpm-installer( 7409): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-06 16:48:26.687+0900 E/rpm-installer( 7409): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-06 16:48:26.687+0900 E/rpm-installer( 7409): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-06 16:48:26.687+0900 E/rpm-installer( 7409): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 16:48:26.687+0900 E/rpm-installer( 7409): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-06 16:48:26.687+0900 E/rpm-installer( 7409): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-06 16:48:26.697+0900 E/PKGMGR_PARSER( 7409): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-06 16:48:26.697+0900 E/PKGMGR_PARSER( 7409): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-06 16:48:26.738+0900 I/PRIVACY-MANAGER-CLIENT( 7409): SocketClient.cpp: SocketClient(37) > Client created
04-06 16:48:26.898+0900 E/PKGMGR_SERVER( 7267): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 16:48:26.938+0900 E/PKGMGR_PARSER( 7409): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-06 16:48:26.958+0900 E/PKGMGR_CERT( 7409): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-06 16:48:26.958+0900 E/PKGMGR_CERT( 7409): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-06 16:48:26.958+0900 E/PKGMGR_CERT( 7409): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-06 16:48:26.958+0900 E/PKGMGR_CERT( 7409): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-06 16:48:26.958+0900 E/PKGMGR_CERT( 7409): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-06 16:48:26.958+0900 E/PKGMGR_CERT( 7409): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-06 16:48:26.958+0900 E/PKGMGR_CERT( 7409): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-06 16:48:26.968+0900 E/PKGMGR_CERT( 7409): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-06 16:48:26.978+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-06 16:48:26.978+0900 I/Tizen::App( 1248): (119) > InstallationInProgress [60]
04-06 16:48:26.978+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-06 16:48:26.988+0900 E/rpm-installer( 7409): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 16:48:27.008+0900 E/rpm-installer( 7409): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-06 16:48:27.018+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-06 16:48:27.018+0900 I/Tizen::App( 1248): (119) > InstallationInProgress [100]
04-06 16:48:27.018+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-06 16:48:28.890+0900 E/PKGMGR_SERVER( 7267): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 16:48:29.100+0900 I/Tizen::App( 1248): (1894) > PackageEventHandler - req: 12480002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-06 16:48:29.100+0900 I/Tizen::App( 1248): (78) > Installation is Completed. [Package = org.example.client]
04-06 16:48:29.100+0900 I/Tizen::App( 1248): (671) > Enter. package(org.example.client), installationResult(0)
04-06 16:48:29.100+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-06 16:48:29.100+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-06 16:48:29.100+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-06 16:48:29.150+0900 W/ISF_PANEL_EFL(  774): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-06 16:48:29.170+0900 I/Tizen::App( 1248): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-06 16:48:29.210+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-06 16:48:29.210+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-06 16:48:29.210+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-06 16:48:29.210+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-06 16:48:29.210+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-06 16:48:29.220+0900 E/PKGMGR_SERVER( 7267): pkgmgr-server.c: sighandler(417) > child NORMAL exit [7409]
04-06 16:48:29.230+0900 I/Tizen::App( 1248): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-06 16:48:29.250+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-06 16:48:29.250+0900 E/HOME_APPS(  869): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-06 16:48:29.250+0900 E/cluster-home(  869): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-06 16:48:29.250+0900 W/HOME_APPS(  869): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-06 16:48:29.260+0900 I/Tizen::App( 1248): (416) > appName = [client]
04-06 16:48:29.260+0900 I/Tizen::App( 1248): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 16:48:29.260+0900 E/PKGMGR_INFO( 1248): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-06 16:48:29.260+0900 I/Tizen::App( 1248): (683) > Application count(1) in this package
04-06 16:48:29.260+0900 I/Tizen::App( 1248): (840) > Enter.
04-06 16:48:29.270+0900 I/Tizen::App( 1248): (703) > Exit.
04-06 16:48:29.270+0900 I/Tizen::App( 1248): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
04-06 16:48:29.270+0900 I/Tizen::App( 1248): (416) > appName = [client]
04-06 16:48:29.270+0900 I/Tizen::App( 1248): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 16:48:29.270+0900 I/Tizen::App( 1248): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-06 16:48:29.270+0900 I/Tizen::App( 1248): (131) > Enter
04-06 16:48:29.270+0900 E/util-view(  869): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-06 16:48:29.270+0900 I/Tizen::App( 1248): (137) > org.example.client does not have launch condition
04-06 16:48:29.270+0900 I/Tizen::App( 1248): (883) > Exit.
04-06 16:48:29.290+0900 W/HOME_APPS(  869): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-06 16:48:30.892+0900 E/PKGMGR_SERVER( 7267): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 16:48:30.892+0900 E/PKGMGR_SERVER( 7267): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 16:48:33.374+0900 W/AUL     ( 7465): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 16:48:33.374+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 16:48:33.384+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 16:48:33.394+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 16:48:33.394+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 16:48:33.394+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 7465
04-06 16:48:33.394+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 16:48:33.414+0900 E/RESOURCED(  665): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-06 16:48:33.414+0900 E/RESOURCED(  665): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 16:48:33.424+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 16:48:33.424+0900 W/AUL_PAD ( 1536): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 16:48:33.424+0900 W/AUL_PAD ( 1536): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 16:48:33.444+0900 I/abc     ( 4140): abc
04-06 16:48:33.444+0900 I/CAPI_APPFW_APPLICATION( 4140): app_main.c: ui_app_main(789) > app_efl_main
04-06 16:48:33.454+0900 I/CAPI_APPFW_APPLICATION( 4140): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 16:48:33.484+0900 E/TBM     ( 4140): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 16:48:33.524+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 4140, appid: org.example.client
04-06 16:48:33.524+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 16:48:33.534+0900 W/AUL     ( 7465): launch.c: app_request_to_launchpad(425) > request cmd(0) result(4140)
04-06 16:48:33.754+0900 D/basicui ( 4140): successed to load edc file
04-06 16:48:33.784+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 16:48:33.784+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 16:48:33.794+0900 I/Tizen::System( 1248): (259) > Active app [org.exampl], current [com.samsun] 
04-06 16:48:33.804+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 16:48:33.804+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 16:48:33.804+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 16:48:33.844+0900 I/MY_LOG  ( 4140): change
04-06 16:48:33.885+0900 I/APP_CORE( 4140): appcore-efl.c: __do_app(514) > [APP 4140] Event: RESET State: CREATED
04-06 16:48:33.885+0900 I/CAPI_APPFW_APPLICATION( 4140): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 16:48:33.905+0900 E/EFL     ( 4140): edje<4140> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 16:48:33.905+0900 E/EFL     ( 4140): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 16:48:33.905+0900 E/EFL     ( 4140): edje<4140> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 16:48:33.905+0900 E/EFL     ( 4140): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 16:48:33.905+0900 E/EFL     ( 4140): edje<4140> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 16:48:33.905+0900 E/EFL     ( 4140): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 16:48:33.915+0900 W/APP_CORE( 4140): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-06 16:48:33.915+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 16:48:34.035+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: PAUSE State: RUNNING
04-06 16:48:34.035+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 16:48:34.035+0900 E/cluster-home(  869): homescreen.cpp: OnPause(260) >  app pause
04-06 16:48:34.035+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(4)
04-06 16:48:34.035+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(869)
04-06 16:48:34.035+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: bg
04-06 16:48:34.035+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(4140) status(3)
04-06 16:48:34.045+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 16:48:34.045+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 16:48:34.045+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(4140)
04-06 16:48:34.045+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 4140, appid: org.example.client, status: fg
04-06 16:48:34.045+0900 I/APP_CORE( 4140): appcore-efl.c: __do_app(514) > [APP 4140] Event: RESUME State: CREATED
04-06 16:48:34.045+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 16:48:34.045+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 16:48:34.045+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: bg
04-06 16:48:34.055+0900 I/APP_CORE( 4140): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 16:48:34.055+0900 I/APP_CORE( 4140): appcore-efl.c: __do_app(625) > [APP 4140] Initial Launching, call the resume_cb
04-06 16:48:34.055+0900 I/CAPI_APPFW_APPLICATION( 4140): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 16:48:34.405+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(4140) status(0)
04-06 16:48:34.585+0900 I/Tizen::App( 1248): (499) > LaunchedApp(org.example.client)
04-06 16:48:34.585+0900 I/Tizen::App( 1248): (733) > Finished invoking application event listener for org.example.client, 4140.
04-06 16:48:34.605+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.431
04-06 16:48:35.366+0900 I/UXT     ( 7479): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 16:48:36.978+0900 E/EFL     ( 4140): ecore_x<4140> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=39674084
04-06 16:48:36.978+0900 I/MY_LOG  ( 4140): Button pressed
04-06 16:48:37.078+0900 E/EFL     ( 4140): ecore_x<4140> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=39674184
04-06 16:48:37.088+0900 E/VCONF   ( 4140): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 16:48:37.088+0900 E/VCONF   ( 4140): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 16:48:37.088+0900 E/VCONF   ( 4140): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 16:48:37.088+0900 E/VCONF   ( 4140): vconf.c: vconf_get_bool(2729) > vconf_get_bool(4140) : db/ise/keysound error
04-06 16:48:37.088+0900 E/VCONF   ( 4140): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 16:48:37.088+0900 E/VCONF   ( 4140): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 16:48:37.138+0900 I/MY_LOG  ( 4140): Button unpressed
04-06 16:48:37.288+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 4140 pgid = 4140
04-06 16:48:37.288+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(143) > dead_pid(4140)
04-06 16:48:37.288+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 16:48:37.298+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(3)
04-06 16:48:37.298+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 16:48:37.298+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 16:48:37.298+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(869)
04-06 16:48:37.298+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: fg
04-06 16:48:37.338+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 16:48:37.338+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 16:48:37.338+0900 E/AUL_PAD ( 1536): launchpad.c: main(698) > error reading sigchld info
04-06 16:48:37.348+0900 I/Tizen::App( 1248): (243) > App[org.example.client] pid[4140] terminate event is forwarded
04-06 16:48:37.348+0900 I/Tizen::System( 1248): (256) > osp.accessorymanager.service provider is found.
04-06 16:48:37.348+0900 I/Tizen::System( 1248): (196) > Accessory Owner is removed [org.example.client, 4140, ]
04-06 16:48:37.348+0900 I/Tizen::System( 1248): (256) > osp.system.service provider is found.
04-06 16:48:37.348+0900 I/Tizen::App( 1248): (506) > TerminatedApp(org.example.client)
04-06 16:48:37.348+0900 I/Tizen::App( 1248): (512) > Not registered pid(4140)
04-06 16:48:37.348+0900 I/Tizen::System( 1248): (246) > Terminated app [org.example.client]
04-06 16:48:37.348+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 16:48:37.348+0900 I/ESD     (  901): esd_main.c: __esd_app_dead_handler(1773) > pid: 4140
04-06 16:48:37.348+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 4140
04-06 16:48:37.348+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 4140
04-06 16:48:37.348+0900 E/EFL     (  663): <663> lib/ecore_ipc/ecore_ipc.c:804 ecore_ipc_client_send() safety check failed: !ecore_con_client_connected_get(cl->client) is true
04-06 16:48:37.348+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.435
04-06 16:48:37.358+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(0)
04-06 16:48:37.368+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 16:48:37.368+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: RESUME State: PAUSED
04-06 16:48:37.368+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 16:48:37.368+0900 E/cluster-home(  869): homescreen.cpp: OnResume(233) >  app resume
04-06 16:48:37.368+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 16:48:37.368+0900 I/Tizen::App( 1248): (782) > Finished invoking application event listener for org.example.client, 4140.
04-06 16:48:37.378+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [org.exampl] 
04-06 16:48:37.378+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 16:48:37.388+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 16:48:37.418+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 16:48:37.418+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 16:48:37.418+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 16:48:37.418+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 16:48:37.428+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 16:48:37.428+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 16:48:37.428+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 16:48:37.428+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: fg
04-06 16:48:37.448+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 16:48:37.448+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 16:48:37.478+0900 W/CRASH_MANAGER( 7484): worker.c: worker_job(1199) > 0604140636c69149146491
