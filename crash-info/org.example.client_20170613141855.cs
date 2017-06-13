S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 20868
Date: 2017-06-13 14:18:55+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 20868, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00005184
r2   = 0x00000006, r3   = 0xb40cb4c0
r4   = 0x00000002, r5   = 0xb40cb000
r6   = 0xb67c509c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb7d9b548
r10  = 0xbe842498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbe8420ec
lr   = 0xb66bbf18, pc   = 0xb66bab84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     50892 KB
Buffers:     66516 KB
Cached:     240828 KB
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
PID = 20868 TID = 20868
20868 20871 21009 

Maps Information
b1b94000 b1b9c000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bad000 b1bae000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bbe000 b1bd2000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1be6000 b1be7000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bf7000 b1bfa000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c0b000 b1c0c000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c1c000 b1c1e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c2e000 b1c30000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c40000 b1c50000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c60000 b1c6c000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c7e000 b247d000 rw-p [stack:21009]
b27ae000 b27b5000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27c8000 b27ce000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27de000 b280e000 r-xp /opt/usr/apps/org.example.client/bin/client
b2957000 b2a3a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a71000 b2a99000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2aab000 b32aa000 rw-p [stack:20871]
b32aa000 b32ac000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32bc000 b32c6000 r-xp /lib/libnss_files-2.20-2014.11.so
b32d7000 b32e0000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32f1000 b3302000 r-xp /lib/libnsl-2.20-2014.11.so
b3315000 b331b000 r-xp /lib/libnss_compat-2.20-2014.11.so
b332c000 b332d000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3355000 b335c000 r-xp /usr/lib/libminizip.so.1.0.0
b336c000 b3371000 r-xp /usr/lib/libstorage.so.0.1
b3381000 b33e0000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33f6000 b340a000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b341a000 b345e000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b346e000 b3476000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3486000 b34b6000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34c9000 b3582000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3596000 b35e9000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35fa000 b3615000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3625000 b36e6000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36f9000 b3709000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3719000 b3726000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3737000 b373e000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b374e000 b378f000 r-xp /usr/lib/libmdm.so.1.2.12
b379f000 b37a7000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37b6000 b37c6000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37e7000 b3847000 r-xp /usr/lib/libasound.so.2.0.0
b3859000 b385c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b386c000 b386f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b387f000 b3884000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3894000 b3895000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38a5000 b38b0000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38c4000 b38cb000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38db000 b38e1000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38f1000 b38f6000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3906000 b3921000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3931000 b3938000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3948000 b394b000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b395c000 b398a000 r-xp /usr/lib/libidn.so.11.5.44
b399a000 b39b0000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39c1000 b39cb000 r-xp /usr/lib/libcares.so.2.1.0
b39db000 b39e5000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39f5000 b39f7000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a07000 b3a08000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a18000 b3a1c000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a2d000 b3a55000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a66000 b3a8f000 r-xp /usr/lib/libturbojpeg.so
b3aaf000 b3ab5000 r-xp /usr/lib/libgif.so.4.1.6
b3ac5000 b3b0b000 r-xp /usr/lib/libcurl.so.4.3.0
b3b1c000 b3b3d000 r-xp /usr/lib/libexif.so.12.3.3
b3b58000 b3b6d000 r-xp /usr/lib/libtts.so
b3b7e000 b3b86000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b96000 b3c5c000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c7c000 b3d74000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d93000 b3e61000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e78000 b3e7a000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e8a000 b3e90000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ea0000 b3ec3000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ed4000 b3ed6000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ee6000 b3ee8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ef9000 b3efe000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f15000 b3f17000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f27000 b3f2e000 r-xp /usr/lib/libsensord-share.so
b3f3e000 b3f56000 r-xp /usr/lib/libsensor.so.1.1.0
b3f67000 b3f6a000 r-xp /usr/lib/libXv.so.1.0.0
b3f7a000 b3f7f000 r-xp /usr/lib/libutilX.so.1.1.0
b3f8f000 b3f94000 r-xp /usr/lib/libappcore-common.so.1.1
b3fa4000 b3fab000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fbe000 b3fc2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fd3000 b40b1000 r-xp /usr/lib/libCOREGL.so.4.0
b40d1000 b40d4000 r-xp /usr/lib/libuuid.so.1.3.0
b40e4000 b40fb000 r-xp /usr/lib/libblkid.so.1.1.0
b410c000 b410e000 r-xp /usr/lib/libXau.so.6.0.0
b411e000 b4165000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4177000 b417d000 r-xp /usr/lib/libjson-c.so.2.0.1
b418e000 b4192000 r-xp /usr/lib/libogg.so.0.7.1
b41a2000 b41c4000 r-xp /usr/lib/libvorbis.so.0.4.3
b41d4000 b42b8000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42d4000 b42d7000 r-xp /usr/lib/libEGL.so.1.4
b42e8000 b42ee000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42fe000 b4300000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4310000 b431d000 r-xp /usr/lib/libGLESv2.so.2.0
b432e000 b4390000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43a5000 b43bd000 r-xp /usr/lib/libmount.so.1.1.0
b43cf000 b43e3000 r-xp /usr/lib/libxcb.so.1.1.0
b43f3000 b43fa000 r-xp /lib/libcrypt-2.20-2014.11.so
b4432000 b4434000 r-xp /usr/lib/libiri.so
b4444000 b444f000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4460000 b4496000 r-xp /usr/lib/libpulse.so.0.16.2
b44a7000 b44ea000 r-xp /usr/lib/libsndfile.so.1.0.25
b44ff000 b4514000 r-xp /lib/libexpat.so.1.5.2
b4526000 b45e4000 r-xp /usr/lib/libcairo.so.2.11200.14
b45f8000 b4600000 r-xp /usr/lib/libdrm.so.2.4.0
b4610000 b4613000 r-xp /usr/lib/libdri2.so.0.0.0
b4623000 b4671000 r-xp /usr/lib/libssl.so.1.0.0
b4686000 b4692000 r-xp /usr/lib/libeeze.so.1.13.0
b46a3000 b46ac000 r-xp /usr/lib/libethumb.so.1.13.0
b46bc000 b46bf000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46cf000 b4886000 r-xp /usr/lib/libcrypto.so.1.0.0
b5671000 b567a000 r-xp /usr/lib/libXi.so.6.1.0
b568a000 b568c000 r-xp /usr/lib/libXgesture.so.7.0.0
b569c000 b56a0000 r-xp /usr/lib/libXtst.so.6.1.0
b56b0000 b56b6000 r-xp /usr/lib/libXrender.so.1.3.0
b56c6000 b56cc000 r-xp /usr/lib/libXrandr.so.2.2.0
b56dc000 b56de000 r-xp /usr/lib/libXinerama.so.1.0.0
b56ef000 b56f2000 r-xp /usr/lib/libXfixes.so.3.1.0
b5702000 b570d000 r-xp /usr/lib/libXext.so.6.4.0
b571d000 b571f000 r-xp /usr/lib/libXdamage.so.1.1.0
b572f000 b5731000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5741000 b5823000 r-xp /usr/lib/libX11.so.6.3.0
b5837000 b583e000 r-xp /usr/lib/libXcursor.so.1.0.2
b584e000 b5866000 r-xp /usr/lib/libudev.so.1.6.0
b5868000 b586b000 r-xp /lib/libattr.so.1.1.0
b587b000 b589b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b589c000 b58a1000 r-xp /usr/lib/libffi.so.6.0.2
b58b2000 b58ca000 r-xp /lib/libz.so.1.2.8
b58da000 b58dc000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58ec000 b59c1000 r-xp /usr/lib/libxml2.so.2.9.2
b59d6000 b5a71000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a8d000 b5a90000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aa0000 b5ab9000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aca000 b5adb000 r-xp /lib/libresolv-2.20-2014.11.so
b5aef000 b5b69000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b7e000 b5b80000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b90000 b5b97000 r-xp /usr/lib/libembryo.so.1.13.0
b5ba7000 b5bb1000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bc2000 b5bda000 r-xp /usr/lib/libpng12.so.0.50.0
b5beb000 b5c0e000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c2f000 b5c43000 r-xp /usr/lib/libector.so.1.13.0
b5c54000 b5c6c000 r-xp /usr/lib/liblua-5.1.so
b5c7d000 b5cd4000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ce8000 b5d10000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d21000 b5d34000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d45000 b5d7f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d90000 b5d9e000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dae000 b5db6000 r-xp /usr/lib/libtbm.so.1.0.0
b5dc6000 b5dd3000 r-xp /usr/lib/libeio.so.1.13.0
b5de3000 b5de5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5df5000 b5dfa000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e0a000 b5e21000 r-xp /usr/lib/libefreet.so.1.13.0
b5e33000 b5e53000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e63000 b5e83000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e85000 b5e8b000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e9b000 b5eac000 r-xp /usr/lib/libemotion.so.1.13.0
b5ebd000 b5ec4000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ed4000 b5ee3000 r-xp /usr/lib/libeo.so.1.13.0
b5ef4000 b5f06000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f17000 b5f1c000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f2c000 b5f45000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f55000 b5f72000 r-xp /usr/lib/libeet.so.1.13.0
b5f8b000 b5fd3000 r-xp /usr/lib/libeina.so.1.13.0
b5fe4000 b5ff4000 r-xp /usr/lib/libefl.so.1.13.0
b6005000 b60ea000 r-xp /usr/lib/libicuuc.so.51.1
b6107000 b6247000 r-xp /usr/lib/libicui18n.so.51.1
b625e000 b6296000 r-xp /usr/lib/libecore_x.so.1.13.0
b62a8000 b62ab000 r-xp /lib/libcap.so.2.21
b62bb000 b62e4000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62f5000 b62fc000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b630e000 b6345000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6356000 b6441000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6454000 b64cd000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64df000 b64e4000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64f4000 b64fe000 r-xp /usr/lib/libvconf.so.0.2.45
b650e000 b6510000 r-xp /usr/lib/libvasum.so.0.3.1
b6520000 b6522000 r-xp /usr/lib/libttrace.so.1.1
b6532000 b6535000 r-xp /usr/lib/libiniparser.so.0
b6545000 b656b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b657b000 b6580000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6591000 b65a8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65b9000 b6624000 r-xp /lib/libm-2.20-2014.11.so
b6635000 b663b000 r-xp /lib/librt-2.20-2014.11.so
b664c000 b6659000 r-xp /usr/lib/libunwind.so.8.0.1
b668f000 b67b3000 r-xp /lib/libc-2.20-2014.11.so
b67c8000 b67e1000 r-xp /lib/libgcc_s-4.9.so.1
b67f1000 b68d3000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68e4000 b690e000 r-xp /usr/lib/libdbus-1.so.3.8.12
b691f000 b695b000 r-xp /usr/lib/libsystemd.so.0.4.0
b695d000 b69e0000 r-xp /usr/lib/libedje.so.1.13.0
b69f3000 b6a11000 r-xp /usr/lib/libecore.so.1.13.0
b6a31000 b6bb8000 r-xp /usr/lib/libevas.so.1.13.0
b6bed000 b6c01000 r-xp /lib/libpthread-2.20-2014.11.so
b6c15000 b6e49000 r-xp /usr/lib/libelementary.so.1.13.0
b6e78000 b6e7c000 r-xp /usr/lib/libsmack.so.1.0.0
b6e8c000 b6e93000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ea3000 b6ea5000 r-xp /usr/lib/libdlog.so.0.0.0
b6eb5000 b6eb8000 r-xp /usr/lib/libbundle.so.0.1.22
b6ec8000 b6eca000 r-xp /lib/libdl-2.20-2014.11.so
b6edb000 b6ef3000 r-xp /usr/lib/libaul.so.0.1.0
b6f07000 b6f0c000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f1d000 b6f2a000 r-xp /usr/lib/liblptcp.so
b6f3c000 b6f40000 r-xp /usr/lib/libsys-assert.so
b6f51000 b6f71000 r-xp /lib/ld-2.20-2014.11.so
b6f82000 b6f87000 r-xp /usr/bin/launchpad-loader
b7d31000 b7f76000 rw-p [heap]
be822000 be843000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20868)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66bab84) [/lib/libc.so.6] + 0x2bb84
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
tialized.
06-13 14:18:39.089+0900 E/TBM     (20815): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:18:39.089+0900 I/MALI    (20815): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=20815   open drm_fd=30 
06-13 14:18:39.219+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:18:39.219+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:18:39.219+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(20294)
06-13 14:18:39.219+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20294, appid: com.samsung.task-mgr, status: bg
06-13 14:18:39.219+0900 I/CAPI_APPFW_APPLICATION(20294): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:18:39.219+0900 W/TASK_MGR_LITE(20294): task-mgr-lite.c: _pause_app(406) > 
06-13 14:18:39.219+0900 I/CAPI_APPFW_APPLICATION(20294): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:18:39.229+0900 E/EFL     (20815): edje<20815> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:18:39.229+0900 E/EFL     (20815): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:18:39.229+0900 E/EFL     (20815): edje<20815> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:18:39.229+0900 E/EFL     (20815): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:18:39.229+0900 E/EFL     (20815): edje<20815> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:18:39.229+0900 E/EFL     (20815): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:18:39.229+0900 E/TASK_MGR_LITE(20294): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:18:39.239+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 14:18:39.249+0900 E/APP_CORE(20294): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:18:39.249+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:18:39.259+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:18:39.259+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:18:39.259+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:18:39.259+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:18:39.259+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:18:39.279+0900 I/MALI    (20294): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=20294   close drm_fd=29 
06-13 14:18:39.289+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:18:39.319+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:18:39.329+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:18:39.329+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:18:39.329+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:18:39.339+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:18:39.339+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:18:39.349+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:18:39.349+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:18:39.349+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:18:39.359+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18105512
06-13 14:18:39.359+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18105556
06-13 14:18:39.359+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:18:39.359+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:18:39.359+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:18:39.359+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:18:39.369+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:18:39.379+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:39.379+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:18:39.379+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:18:39.379+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: bg
06-13 14:18:39.379+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:39.529+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18105703
06-13 14:18:39.529+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:18:39.529+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18105743
06-13 14:18:39.529+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:18:39.539+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 14:18:39.539+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 14:18:39.539+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:18:39.539+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:18:39.579+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:18:39.579+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:18:39.579+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:18:39.579+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:18:39.579+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:18:39.579+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: bg
06-13 14:18:39.589+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 20294 pgid = 20294
06-13 14:18:39.589+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(20294)
06-13 14:18:39.589+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:39.589+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:39.629+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:18:39.629+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:18:39.629+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:18:39.639+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 20294
06-13 14:18:39.639+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 20294
06-13 14:18:39.639+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[20294] terminate event is forwarded
06-13 14:18:39.639+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:18:39.639+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 20294, ]
06-13 14:18:39.639+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:18:39.639+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:18:39.639+0900 I/Tizen::App( 1175): (512) > Not registered pid(20294)
06-13 14:18:39.639+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:18:39.639+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:18:39.639+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 20294
06-13 14:18:39.649+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:18:39.649+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 20294.
06-13 14:18:39.719+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 14:18:39.719+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 14:18:39.719+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnFocusedViewChanged(4344) >  view type is not chaged,same view[0]
06-13 14:18:39.739+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:18:39.739+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:18:39.739+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:18:39.749+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2028
06-13 14:18:39.759+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:39.759+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.170+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18106383
06-13 14:18:40.190+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:18:40.190+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:18:40.200+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:18:40.200+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:18:40.200+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: bg
06-13 14:18:40.290+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18106504
06-13 14:18:40.750+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.760+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.780+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.780+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.800+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.810+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.820+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.830+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.850+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.850+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.860+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.860+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.870+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.880+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.880+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.890+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.890+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.900+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.910+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.920+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.930+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18107144
06-13 14:18:40.940+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.940+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.950+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.950+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.970+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.970+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:41.010+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18107221
06-13 14:18:41.010+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 14:18:41.010+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 14:18:41.010+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 14:18:41.020+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 7
06-13 14:18:41.020+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:18:41.030+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:18:41.030+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:18:41.030+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:18:41.040+0900 I/abc     (20795): abc
06-13 14:18:41.040+0900 I/CAPI_APPFW_APPLICATION(20795): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:18:41.040+0900 I/CAPI_APPFW_APPLICATION(20795): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:18:41.070+0900 E/TBM     (20795): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:18:41.131+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20795, appid: org.example.client
06-13 14:18:41.131+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:18:41.141+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(20795)
06-13 14:18:41.261+0900 W/CRASH_MANAGER(20783): worker.c: worker_job(1199) > 0620795636c691497331121
06-13 14:18:42.152+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 20795 pgid = 20795
06-13 14:18:42.152+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(20795)
06-13 14:18:42.162+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 20795.
06-13 14:18:42.162+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2029
06-13 14:18:42.192+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:18:42.192+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:18:42.192+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:18:42.192+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 20795
06-13 14:18:42.192+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 20795.
06-13 14:18:42.192+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 20795
06-13 14:18:42.192+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 20795
06-13 14:18:42.202+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2030
06-13 14:18:42.642+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18108857
06-13 14:18:42.652+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18108857
06-13 14:18:42.652+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 14:18:42.652+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 14:18:42.652+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 14:18:42.942+0900 I/UXT     (20868): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:18:42.952+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:18:42.952+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:18:42.952+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:18:42.952+0900 E/STARTER (  721): )
06-13 14:18:42.952+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:18:42.952+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:18:42.952+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:18:42.962+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 14:18:42.962+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:18:42.972+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 14:18:42.972+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:18:42.972+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 14:18:42.972+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:18:42.982+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:18:42.982+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:18:42.982+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:18:42.982+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:18:43.002+0900 E/CAPI_APPFW_APPLICATION(20815): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:18:43.002+0900 E/CAPI_APPFW_APPLICATION(20815): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:18:43.002+0900 E/CAPI_APPFW_APPLICATION(20815): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:18:43.002+0900 E/CAPI_APPFW_APPLICATION(20815): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:18:43.002+0900 E/CAPI_APPFW_APPLICATION(20815): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:18:43.002+0900 I/CAPI_APPFW_APPLICATION(20815): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:18:43.002+0900 I/CAPI_APPFW_APPLICATION(20815): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:18:43.082+0900 W/TASK_MGR_LITE(20815): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 14:18:43.082+0900 I/GXT_SIB (20815): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:18:43.082+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20815, appid: com.samsung.task-mgr
06-13 14:18:43.092+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:18:43.102+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20815)
06-13 14:18:43.102+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 14:18:43.122+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:18:43.122+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:18:43.152+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:18:43.152+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:18:43.173+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:18:43.183+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:18:43.183+0900 E/RUA     (20815): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 14:18:43.183+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:18:43.193+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:18:43.193+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:18:43.253+0900 I/APP_CORE(20815): appcore-efl.c: __do_app(514) > [APP 20815] Event: RESET State: CREATED
06-13 14:18:43.253+0900 I/CAPI_APPFW_APPLICATION(20815): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:18:43.253+0900 E/EFL     (20815): edje<20815> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:18:43.253+0900 E/EFL     (20815): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:18:43.253+0900 E/EFL     (20815): edje<20815> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:18:43.253+0900 E/EFL     (20815): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:18:43.263+0900 W/APP_CORE(20815): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800003
06-13 14:18:43.263+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 14:18:43.373+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 14:18:43.373+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:18:43.373+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 14:18:43.373+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 14:18:43.373+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 14:18:43.373+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 14:18:43.373+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(20815) status(3)
06-13 14:18:43.373+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:18:43.373+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:18:43.383+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(20815)
06-13 14:18:43.383+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20815, appid: com.samsung.task-mgr, status: fg
06-13 14:18:43.383+0900 I/APP_CORE(20815): appcore-efl.c: __do_app(514) > [APP 20815] Event: RESUME State: CREATED
06-13 14:18:43.393+0900 I/APP_CORE(20815): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 14:18:43.393+0900 I/APP_CORE(20815): appcore-efl.c: __do_app(625) > [APP 20815] Initial Launching, call the resume_cb
06-13 14:18:43.393+0900 I/CAPI_APPFW_APPLICATION(20815): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:18:43.733+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(20815) status(0)
06-13 14:18:43.763+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:18:43.763+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18109970
06-13 14:18:43.763+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18109970
06-13 14:18:43.763+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:18:43.763+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:18:43.763+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:18:43.763+0900 E/STARTER (  721): )
06-13 14:18:43.763+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:18:43.763+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:18:43.763+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:18:43.763+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:18:44.013+0900 E/EFL     (20815): ecore_x<20815> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18110224
06-13 14:18:44.103+0900 E/EFL     (20815): ecore_x<20815> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18110313
06-13 14:18:44.133+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:18:44.133+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 20815.
06-13 14:18:44.224+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:18:44.484+0900 E/EFL     (20815): ecore_x<20815> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18110696
06-13 14:18:44.574+0900 E/EFL     (20815): ecore_x<20815> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18110784
06-13 14:18:44.904+0900 I/UXT     (20878): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:18:44.954+0900 E/TBM     (20878): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:18:44.954+0900 I/MALI    (20878): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=20878   open drm_fd=30 
06-13 14:18:44.954+0900 E/EFL     (20815): ecore_x<20815> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18111168
06-13 14:18:45.024+0900 E/EFL     (20815): ecore_x<20815> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18111234
06-13 14:18:45.094+0900 E/EFL     (20878): edje<20878> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:18:45.094+0900 E/EFL     (20878): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:18:45.104+0900 E/EFL     (20878): edje<20878> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:18:45.104+0900 E/EFL     (20878): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:18:45.104+0900 E/EFL     (20878): edje<20878> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:18:45.104+0900 E/EFL     (20878): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:18:45.345+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:18:45.345+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:18:45.345+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(20815)
06-13 14:18:45.345+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20815, appid: com.samsung.task-mgr, status: bg
06-13 14:18:45.345+0900 I/CAPI_APPFW_APPLICATION(20815): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:18:45.345+0900 W/TASK_MGR_LITE(20815): task-mgr-lite.c: _pause_app(406) > 
06-13 14:18:45.345+0900 I/CAPI_APPFW_APPLICATION(20815): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:18:45.355+0900 E/TASK_MGR_LITE(20815): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:18:45.365+0900 E/TASK_MGR_LITE(20815): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 14:18:45.375+0900 E/APP_CORE(20815): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:18:45.375+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:18:45.385+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:18:45.385+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:18:45.385+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:18:45.385+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:18:45.385+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:18:45.415+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:18:45.425+0900 I/MALI    (20815): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=20815   close drm_fd=30 
06-13 14:18:45.445+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:18:45.445+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:18:45.445+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:18:45.455+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:18:45.485+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18111652
06-13 14:18:45.485+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18111671
06-13 14:18:45.485+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:18:45.485+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:18:45.485+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:18:45.485+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:18:45.505+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:18:45.505+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:18:45.505+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:18:45.545+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:18:45.545+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:18:45.545+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:18:45.555+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:18:45.555+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:18:45.555+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: bg
06-13 14:18:45.565+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:45.565+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:45.655+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 14:18:45.655+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 14:18:45.675+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:18:45.675+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:18:45.675+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:18:45.705+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:45.705+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:45.765+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 20815 pgid = 20815
06-13 14:18:45.765+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(20815)
06-13 14:18:45.795+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:18:45.795+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:18:45.795+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:18:45.805+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[20815] terminate event is forwarded
06-13 14:18:45.805+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:18:45.805+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 20815, ]
06-13 14:18:45.805+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:18:45.805+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:18:45.805+0900 I/Tizen::App( 1175): (512) > Not registered pid(20815)
06-13 14:18:45.805+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:18:45.805+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:18:45.805+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 20815
06-13 14:18:45.805+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 20815
06-13 14:18:45.805+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 20815
06-13 14:18:45.805+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2037
06-13 14:18:45.825+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:18:45.825+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 20815.
06-13 14:18:46.696+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:46.696+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:46.716+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:46.716+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:46.726+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:46.736+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:46.746+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:46.746+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:46.766+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:46.766+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:46.786+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:46.786+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:46.806+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:46.806+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:46.826+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:46.826+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:46.836+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:46.846+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:46.856+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:46.866+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:46.876+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:46.876+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:46.896+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:46.896+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:50.350+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:18:53.092+0900 E/PKGMGR_SERVER(20950): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:18:53.152+0900 E/PKGMGR  (20948): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-13 14:18:53.182+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:18:53.192+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:18:53.202+0900 E/PKGMGR_SERVER(20950): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20953]
06-13 14:18:55.655+0900 W/AUL     (21002): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 14:18:55.655+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:18:55.665+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-13 14:18:55.665+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-13 14:18:55.665+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:18:55.665+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 21002
06-13 14:18:55.675+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:18:55.675+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 7
06-13 14:18:55.685+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:18:55.685+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:18:55.685+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:18:55.685+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:18:55.695+0900 I/abc     (20868): abc
06-13 14:18:55.695+0900 I/CAPI_APPFW_APPLICATION(20868): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:18:55.695+0900 I/CAPI_APPFW_APPLICATION(20868): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:18:55.725+0900 E/TBM     (20868): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:18:55.785+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20868, appid: org.example.client
06-13 14:18:55.785+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:18:55.785+0900 W/AUL     (21002): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20868)
06-13 14:18:55.795+0900 E/PKGMGR_SERVER(20950): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:18:55.795+0900 E/PKGMGR_SERVER(20950): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:18:55.945+0900 W/CRASH_MANAGER(20783): worker.c: worker_job(1199) > 0620868636c69149733113
