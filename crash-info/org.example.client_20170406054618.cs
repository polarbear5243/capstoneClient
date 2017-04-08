S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 15237
Date: 2017-04-06 05:46:18+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 15237, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00003b85
r2   = 0x00000006, r3   = 0xb40b04c0
r4   = 0x00000002, r5   = 0xb40b0000
r6   = 0xb67aa09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5ed8708
r10  = 0xb738cbd8, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbecd3c2c
lr   = 0xb66a0f18, pc   = 0xb669fb84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     75908 KB
Buffers:     64788 KB
Cached:     284492 KB
VmPeak:     133924 KB
VmSize:     133920 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28340 KB
VmRSS:       28340 KB
VmData:      45860 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 15237 TID = 15237
15237 15238 15310 15311 15349 

Maps Information
aee4c000 af64b000 rw-p [stack:15349]
b0f55000 b0f66000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f76000 b0f7b000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b137d000 b1385000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1397000 b1b96000 rw-p [stack:15311]
b1b96000 b1b97000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1ba7000 b1bbb000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bcf000 b1bd0000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1be0000 b1be3000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bf4000 b1bf5000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c05000 b1c07000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c17000 b1c19000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c29000 b1c39000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c49000 b1c55000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c67000 b2466000 rw-p [stack:15310]
b2797000 b279e000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27b1000 b27b7000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27c7000 b27e3000 r-xp /opt/usr/apps/org.example.client/bin/client
b293c000 b2a1f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a56000 b2a7e000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a90000 b328f000 rw-p [stack:15238]
b328f000 b3291000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32a1000 b32ab000 r-xp /lib/libnss_files-2.20-2014.11.so
b32bc000 b32c5000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32d6000 b32e7000 r-xp /lib/libnsl-2.20-2014.11.so
b32fa000 b3300000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3311000 b3312000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b333a000 b3341000 r-xp /usr/lib/libminizip.so.1.0.0
b3351000 b3356000 r-xp /usr/lib/libstorage.so.0.1
b3366000 b33c5000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33db000 b33ef000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33ff000 b3443000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3453000 b345b000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b346b000 b349b000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34ae000 b3567000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b357b000 b35ce000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35df000 b35fa000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b360a000 b36cb000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36de000 b36ee000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36fe000 b370b000 r-xp /usr/lib/libmdm-common.so.1.0.98
b371c000 b3723000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3733000 b3774000 r-xp /usr/lib/libmdm.so.1.2.12
b3784000 b378c000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b379b000 b37ab000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37cc000 b382c000 r-xp /usr/lib/libasound.so.2.0.0
b383e000 b3841000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3851000 b3854000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3864000 b3869000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3879000 b387a000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b388a000 b3895000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38a9000 b38b0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38c0000 b38c6000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38d6000 b38db000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38eb000 b3906000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3916000 b391d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b392d000 b3930000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3941000 b396f000 r-xp /usr/lib/libidn.so.11.5.44
b397f000 b3995000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39a6000 b39b0000 r-xp /usr/lib/libcares.so.2.1.0
b39c0000 b39ca000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39da000 b39dc000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ec000 b39ed000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39fd000 b3a01000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a12000 b3a3a000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a4b000 b3a74000 r-xp /usr/lib/libturbojpeg.so
b3a94000 b3a9a000 r-xp /usr/lib/libgif.so.4.1.6
b3aaa000 b3af0000 r-xp /usr/lib/libcurl.so.4.3.0
b3b01000 b3b22000 r-xp /usr/lib/libexif.so.12.3.3
b3b3d000 b3b52000 r-xp /usr/lib/libtts.so
b3b63000 b3b6b000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b7b000 b3c41000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c61000 b3d59000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d78000 b3e46000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e5d000 b3e5f000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e6f000 b3e75000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e85000 b3ea8000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3eb9000 b3ebb000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ecb000 b3ecd000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ede000 b3ee3000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3efa000 b3efc000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f0c000 b3f13000 r-xp /usr/lib/libsensord-share.so
b3f23000 b3f3b000 r-xp /usr/lib/libsensor.so.1.1.0
b3f4c000 b3f4f000 r-xp /usr/lib/libXv.so.1.0.0
b3f5f000 b3f64000 r-xp /usr/lib/libutilX.so.1.1.0
b3f74000 b3f79000 r-xp /usr/lib/libappcore-common.so.1.1
b3f89000 b3f90000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fa3000 b3fa7000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fb8000 b4096000 r-xp /usr/lib/libCOREGL.so.4.0
b40b6000 b40b9000 r-xp /usr/lib/libuuid.so.1.3.0
b40c9000 b40e0000 r-xp /usr/lib/libblkid.so.1.1.0
b40f1000 b40f3000 r-xp /usr/lib/libXau.so.6.0.0
b4103000 b414a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b415c000 b4162000 r-xp /usr/lib/libjson-c.so.2.0.1
b4173000 b4177000 r-xp /usr/lib/libogg.so.0.7.1
b4187000 b41a9000 r-xp /usr/lib/libvorbis.so.0.4.3
b41b9000 b429d000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42b9000 b42bc000 r-xp /usr/lib/libEGL.so.1.4
b42cd000 b42d3000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42e3000 b42e5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42f5000 b4302000 r-xp /usr/lib/libGLESv2.so.2.0
b4313000 b4375000 r-xp /usr/lib/libpixman-1.so.0.28.2
b438a000 b43a2000 r-xp /usr/lib/libmount.so.1.1.0
b43b4000 b43c8000 r-xp /usr/lib/libxcb.so.1.1.0
b43d8000 b43df000 r-xp /lib/libcrypt-2.20-2014.11.so
b4417000 b4419000 r-xp /usr/lib/libiri.so
b4429000 b4434000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4445000 b447b000 r-xp /usr/lib/libpulse.so.0.16.2
b448c000 b44cf000 r-xp /usr/lib/libsndfile.so.1.0.25
b44e4000 b44f9000 r-xp /lib/libexpat.so.1.5.2
b450b000 b45c9000 r-xp /usr/lib/libcairo.so.2.11200.14
b45dd000 b45e5000 r-xp /usr/lib/libdrm.so.2.4.0
b45f5000 b45f8000 r-xp /usr/lib/libdri2.so.0.0.0
b4608000 b4656000 r-xp /usr/lib/libssl.so.1.0.0
b466b000 b4677000 r-xp /usr/lib/libeeze.so.1.13.0
b4688000 b4691000 r-xp /usr/lib/libethumb.so.1.13.0
b46a1000 b46a4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46b4000 b486b000 r-xp /usr/lib/libcrypto.so.1.0.0
b5656000 b565f000 r-xp /usr/lib/libXi.so.6.1.0
b566f000 b5671000 r-xp /usr/lib/libXgesture.so.7.0.0
b5681000 b5685000 r-xp /usr/lib/libXtst.so.6.1.0
b5695000 b569b000 r-xp /usr/lib/libXrender.so.1.3.0
b56ab000 b56b1000 r-xp /usr/lib/libXrandr.so.2.2.0
b56c1000 b56c3000 r-xp /usr/lib/libXinerama.so.1.0.0
b56d4000 b56d7000 r-xp /usr/lib/libXfixes.so.3.1.0
b56e7000 b56f2000 r-xp /usr/lib/libXext.so.6.4.0
b5702000 b5704000 r-xp /usr/lib/libXdamage.so.1.1.0
b5714000 b5716000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5726000 b5808000 r-xp /usr/lib/libX11.so.6.3.0
b581c000 b5823000 r-xp /usr/lib/libXcursor.so.1.0.2
b5833000 b584b000 r-xp /usr/lib/libudev.so.1.6.0
b584d000 b5850000 r-xp /lib/libattr.so.1.1.0
b5860000 b5880000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5881000 b5886000 r-xp /usr/lib/libffi.so.6.0.2
b5897000 b58af000 r-xp /lib/libz.so.1.2.8
b58bf000 b58c1000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58d1000 b59a6000 r-xp /usr/lib/libxml2.so.2.9.2
b59bb000 b5a56000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a72000 b5a75000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a85000 b5a9e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aaf000 b5ac0000 r-xp /lib/libresolv-2.20-2014.11.so
b5ad4000 b5b4e000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b63000 b5b65000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b75000 b5b7c000 r-xp /usr/lib/libembryo.so.1.13.0
b5b8c000 b5b96000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5ba7000 b5bbf000 r-xp /usr/lib/libpng12.so.0.50.0
b5bd0000 b5bf3000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c14000 b5c28000 r-xp /usr/lib/libector.so.1.13.0
b5c39000 b5c51000 r-xp /usr/lib/liblua-5.1.so
b5c62000 b5cb9000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ccd000 b5cf5000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d06000 b5d19000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d2a000 b5d64000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d75000 b5d83000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d93000 b5d9b000 r-xp /usr/lib/libtbm.so.1.0.0
b5dab000 b5db8000 r-xp /usr/lib/libeio.so.1.13.0
b5dc8000 b5dca000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dda000 b5ddf000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5def000 b5e06000 r-xp /usr/lib/libefreet.so.1.13.0
b5e18000 b5e38000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e48000 b5e68000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e6a000 b5e70000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e80000 b5e91000 r-xp /usr/lib/libemotion.so.1.13.0
b5ea2000 b5ea9000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eb9000 b5ec8000 r-xp /usr/lib/libeo.so.1.13.0
b5ed9000 b5eeb000 r-xp /usr/lib/libecore_input.so.1.13.0
b5efc000 b5f01000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f11000 b5f2a000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f3a000 b5f57000 r-xp /usr/lib/libeet.so.1.13.0
b5f70000 b5fb8000 r-xp /usr/lib/libeina.so.1.13.0
b5fc9000 b5fd9000 r-xp /usr/lib/libefl.so.1.13.0
b5fea000 b60cf000 r-xp /usr/lib/libicuuc.so.51.1
b60ec000 b622c000 r-xp /usr/lib/libicui18n.so.51.1
b6243000 b627b000 r-xp /usr/lib/libecore_x.so.1.13.0
b628d000 b6290000 r-xp /lib/libcap.so.2.21
b62a0000 b62c9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62da000 b62e1000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62f3000 b632a000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b633b000 b6426000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6439000 b64b2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64c4000 b64c9000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64d9000 b64e3000 r-xp /usr/lib/libvconf.so.0.2.45
b64f3000 b64f5000 r-xp /usr/lib/libvasum.so.0.3.1
b6505000 b6507000 r-xp /usr/lib/libttrace.so.1.1
b6517000 b651a000 r-xp /usr/lib/libiniparser.so.0
b652a000 b6550000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6560000 b6565000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6576000 b658d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b659e000 b6609000 r-xp /lib/libm-2.20-2014.11.so
b661a000 b6620000 r-xp /lib/librt-2.20-2014.11.so
b6631000 b663e000 r-xp /usr/lib/libunwind.so.8.0.1
b6674000 b6798000 r-xp /lib/libc-2.20-2014.11.so
b67ad000 b67c6000 r-xp /lib/libgcc_s-4.9.so.1
b67d6000 b68b8000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68c9000 b68f3000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6904000 b6940000 r-xp /usr/lib/libsystemd.so.0.4.0
b6942000 b69c5000 r-xp /usr/lib/libedje.so.1.13.0
b69d8000 b69f6000 r-xp /usr/lib/libecore.so.1.13.0
b6a16000 b6b9d000 r-xp /usr/lib/libevas.so.1.13.0
b6bd2000 b6be6000 r-xp /lib/libpthread-2.20-2014.11.so
b6bfa000 b6e2e000 r-xp /usr/lib/libelementary.so.1.13.0
b6e5d000 b6e61000 r-xp /usr/lib/libsmack.so.1.0.0
b6e71000 b6e78000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e88000 b6e8a000 r-xp /usr/lib/libdlog.so.0.0.0
b6e9a000 b6e9d000 r-xp /usr/lib/libbundle.so.0.1.22
b6ead000 b6eaf000 r-xp /lib/libdl-2.20-2014.11.so
b6ec0000 b6ed8000 r-xp /usr/lib/libaul.so.0.1.0
b6eec000 b6ef1000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f02000 b6f0f000 r-xp /usr/lib/liblptcp.so
b6f21000 b6f25000 r-xp /usr/lib/libsys-assert.so
b6f36000 b6f56000 r-xp /lib/ld-2.20-2014.11.so
b6f67000 b6f6c000 r-xp /usr/bin/launchpad-loader
b7009000 b73e8000 rw-p [heap]
becb4000 becd5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15237)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb669fb84) [/lib/libc.so.6] + 0x2bb84
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
b/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223039216
04-06 05:45:19.954+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
04-06 05:45:19.954+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223039326
04-06 05:45:19.954+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[271]  Y[323] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:19.954+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:19.954+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
04-06 05:45:19.964+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:19.964+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:20.054+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223039426
04-06 05:45:20.054+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223039426
04-06 05:45:20.154+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223039525
04-06 05:45:20.154+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[663]  Y[317] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:20.154+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:20.154+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
04-06 05:45:20.164+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:20.164+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:20.184+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
04-06 05:45:20.414+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
04-06 05:45:20.414+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
04-06 05:45:20.414+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
04-06 05:45:20.424+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 3[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 3, line_count = 0[0m
04-06 05:45:20.824+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223040195
04-06 05:45:20.824+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223040195
04-06 05:45:20.924+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
04-06 05:45:20.944+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223040305
04-06 05:45:20.944+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[53]  Y[315] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:20.944+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:20.954+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
04-06 05:45:20.954+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:20.954+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:21.095+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223040460
04-06 05:45:21.095+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223040460
04-06 05:45:21.185+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223040549
04-06 05:45:21.185+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[671]  Y[517] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:21.185+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:21.185+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:21.195+0900 I/MY_LOG  (14984): change
04-06 05:45:21.205+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:21.215+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:21.975+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223041337
04-06 05:45:21.985+0900 I/MY_LOG  (14984): Button pressed
04-06 05:45:22.066+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223041415
04-06 05:45:22.066+0900 I/ISE_MULTI(  851): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
04-06 05:45:22.086+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
04-06 05:45:22.306+0900 I/MY_LOG  (14984): Button unpressed
04-06 05:45:22.326+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6400002 FAILED!
04-06 05:45:24.928+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223044293
04-06 05:45:25.379+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223044745
04-06 05:45:25.549+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223044912
04-06 05:45:25.799+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223045155
04-06 05:45:25.999+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223045365
04-06 05:45:26.240+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223045608
04-06 05:45:26.790+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223046156
04-06 05:45:26.880+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223046244
04-06 05:45:26.900+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6400002 FAILED!
04-06 05:45:26.900+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6400002 FAILED!
04-06 05:45:26.900+0900 I/ISE_MULTI(  851): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:true] mode=0[0m
04-06 05:45:26.910+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-06 05:45:26.950+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
04-06 05:45:26.950+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
04-06 05:45:26.950+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
04-06 05:45:26.950+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
04-06 05:45:26.950+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
04-06 05:45:26.960+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:27.000+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 3[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 3, line_count = 0[0m
04-06 05:45:27.010+0900 E/ISE_MULTI(  851): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 577  rect->height : 577[0m
04-06 05:45:27.010+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
04-06 05:45:27.010+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:27.050+0900 I/ISE_MULTI(  851): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-06 05:45:27.131+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:27.141+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 1[0m
04-06 05:45:27.141+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.141+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 631, total_width = 0[0m
04-06 05:45:27.141+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 1, line_count = 0[0m
04-06 05:45:27.141+0900 I/ISE_MULTI(  851): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=3[0m
04-06 05:45:27.141+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:27.151+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 1[0m
04-06 05:45:27.151+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.151+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 631, total_width = 0[0m
04-06 05:45:27.151+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 1, line_count = 0[0m
04-06 05:45:27.231+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(851) status(3)
04-06 05:45:27.271+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
04-06 05:45:27.271+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
04-06 05:45:27.621+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223046983
04-06 05:45:27.621+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223046983
04-06 05:45:27.621+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[667]  Y[421] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:27.631+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:27.631+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:27.641+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-06 05:45:27.661+0900 I/MY_LOG  (14984): change
04-06 05:45:27.671+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:27.671+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:27.671+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 10, line_count = 2[0m
04-06 05:45:27.731+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223047083
04-06 05:45:27.731+0900 I/ISE_MULTI(  851): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=2[0m
04-06 05:45:27.841+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047204
04-06 05:45:27.841+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047204
04-06 05:45:27.851+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[659]  Y[419] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:27.851+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:27.851+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:27.861+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-06 05:45:27.871+0900 I/MY_LOG  (14984): change
04-06 05:45:27.871+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:27.871+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:27.871+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.891+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.891+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.891+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.891+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-06 05:45:27.901+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223047226
04-06 05:45:27.911+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047271
04-06 05:45:27.911+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047271
04-06 05:45:27.921+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[660]  Y[423] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:27.921+0900 I/ISE_MULTI(  851): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=1[0m
04-06 05:45:27.931+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:27.931+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:27.971+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-06 05:45:27.971+0900 W/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
04-06 05:45:27.971+0900 I/MY_LOG  (14984): change
04-06 05:45:27.971+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:27.981+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:27.981+0900 I/ISE_MULTI(  851): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:false] mode=1[0m
04-06 05:45:27.981+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-06 05:45:28.021+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223047381
04-06 05:45:28.021+0900 I/ISE_MULTI(  851): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
04-06 05:45:28.071+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047436
04-06 05:45:28.071+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047436
04-06 05:45:28.081+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[658]  Y[434] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:28.081+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:28.081+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:28.081+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:28.081+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:28.151+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223047513
04-06 05:45:28.192+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047548
04-06 05:45:28.192+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047548
04-06 05:45:28.202+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[662]  Y[439] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:28.202+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:28.202+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:28.202+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:28.212+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:28.212+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223047569
04-06 05:45:28.702+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223048058
04-06 05:45:28.702+0900 I/MY_LOG  (14984): Button pressed
04-06 05:45:28.792+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223048145
04-06 05:45:28.792+0900 I/ISE_MULTI(  851): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
04-06 05:45:28.802+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
04-06 05:45:28.862+0900 I/MY_LOG  (14984): Button unpressed
04-06 05:45:28.882+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6400002 FAILED!
04-06 05:45:30.484+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223049849
04-06 05:45:30.664+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223050026
04-06 05:45:31.094+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223050454
04-06 05:45:31.194+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223050553
04-06 05:45:31.875+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223051237
04-06 05:45:32.035+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223051391
04-06 05:45:32.576+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223051924
04-06 05:45:32.756+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223052101
04-06 05:45:33.517+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223052859
04-06 05:45:33.957+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223053311
04-06 05:45:34.207+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223053554
04-06 05:45:34.828+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223054172
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:46:00.403+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 05:46:00.403+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 5:46
04-06 05:46:00.403+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 5:46"
04-06 05:46:00.403+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 5:46"
04-06 05:46:00.403+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 05:46:00.403+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145782436 Time: <font_size=31> </font_size> <font_size=31> 오전 5:46</font_size></font>"
04-06 05:46:06.048+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223085415
04-06 05:46:06.048+0900 I/MY_LOG  (14984): Button pressed
04-06 05:46:06.119+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223085481
04-06 05:46:06.119+0900 I/MY_LOG  (14984): Button unpressed
04-06 05:46:06.669+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=223085998
04-06 05:46:06.669+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=223086033
04-06 05:46:06.689+0900 E/EFL     (14984): elementary<14984> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-06 05:46:08.040+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223086887
04-06 05:46:08.040+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223087020
04-06 05:46:08.050+0900 I/MY_LOG  (14984): Button pressed
04-06 05:46:08.050+0900 I/MY_LOG  (14984): Button unpressed
04-06 05:46:08.221+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14984 pgid = 14984
04-06 05:46:08.221+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(14984)
04-06 05:46:08.231+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:08.241+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 05:46:08.241+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:46:08.241+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:46:08.241+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 05:46:08.241+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 05:46:08.271+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:46:08.271+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:46:08.271+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 05:46:08.281+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 14984
04-06 05:46:08.281+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[14984] terminate event is forwarded
04-06 05:46:08.281+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 05:46:08.281+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 14984, ]
04-06 05:46:08.281+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 05:46:08.281+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 05:46:08.281+0900 I/Tizen::App( 1231): (512) > Not registered pid(14984)
04-06 05:46:08.281+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 05:46:08.281+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:08.281+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14984
04-06 05:46:08.281+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14984
04-06 05:46:08.281+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2358
04-06 05:46:08.291+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 05:46:08.291+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:08.291+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 14984.
04-06 05:46:08.311+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 05:46:08.311+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:46:08.311+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 05:46:08.311+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:08.341+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 05:46:08.341+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 05:46:08.341+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:08.361+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:08.371+0900 W/CRASH_MANAGER(15286): worker.c: worker_job(1199) > 0614984636c691491425168
04-06 05:46:08.371+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 05:46:08.401+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 05:46:08.401+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:46:08.411+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 05:46:08.411+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 05:46:08.411+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:46:08.411+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:08.431+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7923f80]
04-06 05:46:08.431+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 05:46:08.431+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7923f80
04-06 05:46:08.441+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 05:46:08.451+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 05:46:08.451+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:46:08.451+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:46:08.451+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 05:46:10.323+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223089687
04-06 05:46:10.613+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223089973
04-06 05:46:10.873+0900 W/cluster-view(  858): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-06 05:46:11.794+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223091168
04-06 05:46:11.874+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223091245
04-06 05:46:11.874+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-06 05:46:11.874+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
04-06 05:46:11.884+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 858
04-06 05:46:11.894+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 05:46:11.894+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:46:11.894+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:46:11.894+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:46:11.894+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:46:11.904+0900 I/abc     (15237): abc
04-06 05:46:11.904+0900 I/CAPI_APPFW_APPLICATION(15237): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:46:11.914+0900 I/CAPI_APPFW_APPLICATION(15237): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:46:11.944+0900 E/TBM     (15237): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:46:11.994+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15237, appid: org.example.client
04-06 05:46:11.994+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:46:12.004+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(425) > request cmd(1) result(15237)
04-06 05:46:12.235+0900 D/basicui (15237): successed to load edc file
04-06 05:46:12.285+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:12.285+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:12.305+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:46:12.315+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:46:12.315+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:12.325+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:12.355+0900 I/MY_LOG  (15237): change
04-06 05:46:12.405+0900 I/APP_CORE(15237): appcore-efl.c: __do_app(514) > [APP 15237] Event: RESET State: CREATED
04-06 05:46:12.405+0900 I/CAPI_APPFW_APPLICATION(15237): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:46:12.415+0900 E/EFL     (15237): edje<15237> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:12.415+0900 E/EFL     (15237): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:12.425+0900 E/EFL     (15237): edje<15237> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:12.425+0900 E/EFL     (15237): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:12.425+0900 E/EFL     (15237): edje<15237> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:46:12.425+0900 E/EFL     (15237): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:46:12.435+0900 W/APP_CORE(15237): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
04-06 05:46:12.435+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:46:12.565+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 05:46:12.565+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:46:12.565+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 05:46:12.565+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 05:46:12.565+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 05:46:12.565+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 05:46:12.575+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(15237) status(3)
04-06 05:46:12.575+0900 I/APP_CORE(15237): appcore-efl.c: __do_app(514) > [APP 15237] Event: RESUME State: CREATED
04-06 05:46:12.585+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:46:12.585+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:46:12.585+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 05:46:12.585+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(15237)
04-06 05:46:12.585+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 15237, appid: org.example.client, status: fg
04-06 05:46:12.585+0900 I/APP_CORE(15237): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:46:12.585+0900 I/APP_CORE(15237): appcore-efl.c: __do_app(625) > [APP 15237] Initial Launching, call the resume_cb
04-06 05:46:12.585+0900 I/CAPI_APPFW_APPLICATION(15237): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:46:12.915+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(15237) status(0)
04-06 05:46:13.035+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 05:46:13.035+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 15237.
04-06 05:46:13.866+0900 I/UXT     (15318): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:46:14.927+0900 E/EFL     (15237): ecore_x<15237> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223094292
04-06 05:46:15.027+0900 E/EFL     (15237): ecore_x<15237> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223094391
04-06 05:46:16.989+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:46:16.989+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:46:16.989+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:46:16.989+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:46:16.989+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:46:16.989+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:46:16.989+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 05:46:16.989+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:46:16.989+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:46:16.989+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:46:16.989+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:46:16.989+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:46:17.570+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: MEM_FLUSH State: PAUSED
04-06 05:46:18.040+0900 E/EFL     (15237): ecore_x<15237> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223097405
04-06 05:46:18.040+0900 I/MY_LOG  (15237): Button pressed
04-06 05:46:18.140+0900 E/EFL     (15237): ecore_x<15237> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223097505
04-06 05:46:18.150+0900 E/VCONF   (15237): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:46:18.150+0900 E/VCONF   (15237): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:46:18.150+0900 E/VCONF   (15237): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:46:18.150+0900 E/VCONF   (15237): vconf.c: vconf_get_bool(2729) > vconf_get_bool(15237) : db/ise/keysound error
04-06 05:46:18.150+0900 E/VCONF   (15237): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:46:18.150+0900 E/VCONF   (15237): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:46:18.200+0900 I/MY_LOG  (15237): Button unpressed
04-06 05:46:18.391+0900 W/CRASH_MANAGER(15286): worker.c: worker_job(1199) > 0615237636c69149142517
